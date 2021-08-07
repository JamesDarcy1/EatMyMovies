using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatMyMovies.Models
{
    public class Movie
    {
        string MovieID { get; }
        string Title { get; set; }
        string PosterPath { get; set; }
        List<string> Genres { get; set; }
        string IMDBRating { get; set; }

        public Movie()
        {

        }
    }
}
