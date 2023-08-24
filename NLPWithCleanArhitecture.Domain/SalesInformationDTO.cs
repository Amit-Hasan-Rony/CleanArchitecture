using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPWithCleanArhitecture.Domain
{
    public class SalesInformationDTO
    {
        public string SalesOrderCode { set; get; }
        public string CustomerName { set; get; }
        public decimal NetAmount { set; get; }
        public decimal TotalQuantity { set; get; }
        public DateTime InvoiceTime { set; get; }
        public string Itemname { set; get; }
    }
}
