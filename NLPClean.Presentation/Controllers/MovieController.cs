using Google.Cloud.Dialogflow.V2;
using Google.Protobuf;
using Microsoft.AspNetCore.Mvc;
using NLPCleanArchitecture.Application;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using MySqlX.Serialization;
using JsonParser = Google.Protobuf.JsonParser;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Dialogflow.v2;
using Google.Apis.Http;
using Microsoft.Data.SqlClient;
using System.Data;
using Google.Type;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using NLPWithCleanArhitecture.Domain;
using DateTime = System.DateTime;

namespace NLPClean.Presentation.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;


        private static readonly JsonParser jsonParser =
                            new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));

        public static string ConnectionString = "Data Source=10.209.99.144;Initial Catalog = PrinceBazar; User ID = smeapp; Password=sds#dt454sesa0wdnp@1vpo#98;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;";

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        [HttpGet]
        [Route("index")]
        public IActionResult GetMovieList()
        {
            return Ok(_movieService.GetMovies());
        }


        [HttpPost]
        [Route("PostApi")]
        public async Task<IActionResult> PostApi(object obj)
        {
            return Ok("Got the Parameter");
        }

        //start
        [HttpPost]
        [Route("DialogFlow")]
        public async Task<ContentResult> DialogAction()
        {
            WebhookRequest request;
            using (var reader = new StreamReader(Request.Body))
            {
                string requestBody = await reader.ReadToEndAsync();
                request = jsonParser.Parse<WebhookRequest>(requestBody);
            }

            if (request.QueryResult.Action == "FindSalesOrder")
            {
                var requestParameters = request.QueryResult.Parameters;
                var SalesOrderId = requestParameters.Fields["phone-number"].StringValue.ToString();
            }
            WebhookResponse response = new WebhookResponse
            {
                FulfillmentText = $"Thank you for choosing our hotel, your total amount for the {{ totalNights}}nights for {{ totalPersons}}persons will be {{ totalAmount}}USD."
            };
            string responseJson = response.ToString();
            return Content(responseJson, "application/json");
        }
        //end


        //new code for agent create......
        public static GoogleCredential CreateGoogleCredential()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "nlpagent-vjxp-efe703221cd3.json");
            GoogleCredential credential = GoogleCredential.FromFile(filePath);

            // You can also add scopes or other configurations to the credential if needed.
            credential = credential.CreateScoped(DialogflowService.Scope.CloudPlatform);
            
            return credential;
        }
        //mew code for agent create......

        [HttpGet]
        [Route("CallAgent")]
        public async Task<IActionResult> CallAgent(string Queries)
        {
            List<SalesInformationDTO> listInformation = new List<SalesInformationDTO>();
            string currentSession = Guid.NewGuid().ToString();
            GoogleCredential credential = CreateGoogleCredential();
            var response = await new DialogflowService(new Google.Apis.Services.BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "nlpagent-vjxp",
            }).Projects.Agent.Sessions.DetectIntent(
                new Google.Apis.Dialogflow.v2.Data.GoogleCloudDialogflowV2DetectIntentRequest
                {
                    QueryInput = new Google.Apis.Dialogflow.v2.Data.GoogleCloudDialogflowV2QueryInput
                    {
                        Text = new Google.Apis.Dialogflow.v2.Data.GoogleCloudDialogflowV2TextInput
                        {
                            Text = Queries,
                            LanguageCode = "en" // Specify the language code
                        }
                    }
                },
                "projects/" + "nlpagent-vjxp" + "/agent/sessions/" + currentSession)
                .ExecuteAsync();

            dynamic queryResult = response.QueryResult;



            var requestParameters = queryResult.Parameters;
            var SalesOrderId = "";
            try
            {
                SalesOrderId = requestParameters["phone-number"].ToString();
            }
            catch
            {
                SalesOrderId = "";
            }
            if (String.IsNullOrEmpty(SalesOrderId))
            {
                SalesOrderId = "";
                return Ok("Sorry. NO Data Found");
            }
                
            //generate query for finding database..............
            using (SqlConnection _con = new SqlConnection(ConnectionString))
            {

                
                string queryStatement = "select h.SalesOrderCode,pt.PartnerName,h.NetAmount, h.TotalQuantity, h.ActionTime, l.ItemName from pos.POSSalesDeliveryHeader h join pos.POSSalesDeliveryLine l on h.SalesOrderId = l.SalesOrderId join Partner pt on h.CustomerId = pt.PartnerId where h.SalesOrderCode like '%" + SalesOrderId + "%'";

                using (SqlCommand command = new SqlCommand(queryStatement, _con))
                {
                    _con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SalesInformationDTO Infomration = new SalesInformationDTO();
                            Infomration.SalesOrderCode = reader.IsDBNull(0) ? "" : reader.GetString(0);
                            Infomration.CustomerName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            Infomration.NetAmount = reader.IsDBNull(2) ? 0.0M : reader.GetDecimal(2);
                            Infomration.TotalQuantity = reader.IsDBNull(3) ? 0.0M : reader.GetDecimal(3);
                            Infomration.InvoiceTime = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
                            Infomration.Itemname = reader.IsDBNull(5) ? "" : reader.GetString(5);

                            listInformation.Add(Infomration);
                        }
                    }
                    _con.Close();
                }



            }
            //generate query for finding database..............
            if (listInformation.Count > 0)
                return Ok(listInformation);
            else
                return Ok("Sorry. NO Data Found");
        }
    }
}
