using NLPWithCleanArhitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPCleanArchitecture.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository) 
        {
            _movieRepository = movieRepository;
        }
        public List<Movies> GetMovies()
        {
            return (_movieRepository.GetMovies());
        }
    }
}
