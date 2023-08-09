using Microsoft.AspNetCore.Mvc;
using NLPCleanArchitecture.Application;

namespace NLPClean.Presentation.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
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
    }
}
