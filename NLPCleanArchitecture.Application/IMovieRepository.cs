using NLPWithCleanArhitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPCleanArchitecture.Application
{
    public interface IMovieRepository
    {
        public List<Movies> GetMovies();
    }
}
