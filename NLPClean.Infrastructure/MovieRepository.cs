using NLPCleanArchitecture.Application;
using NLPWithCleanArhitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPClean.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly Context _context;

        public MovieRepository(Context context)
        {
            _context = context;
        }

        public List<Movies> GetMovies()
        {
            var newMovewList = new List<Movies>()
            {
                new Movies() {MovieId = 1, MovieName ="Pirates of the Carabian", ProviderName = "Amit Hasan Rony"},
                new Movies() {MovieId = 2, MovieName ="A Beautiful Mind", ProviderName = "Amit Hasan Rony"},
            };


            var response = _context.PossalesDeliveryHeaders.Select(n => new Movies
            {
                MovieId = n.SalesOrderId,
                MovieName = n.SalesOrderCode,
                ProviderName = n.CustomerName,
            }).Take(20).ToList();

            return response;
        }
    }
}
