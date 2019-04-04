using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class DbOperations
    {
        public static List<Movie> GetMovies()
        {
            var _movies = new List<Movie>();
            using (var context = new Context())
            {
                _movies = context.MovieContext.ToList<Movie>();
                foreach (var movie in _movies)
                {
                    movie.DirectorName = context.DirectorContext.FirstOrDefault(x => x.Id == movie.DirectorId);
                }
            }
            return _movies;
        }

        public static List<Director> GetDirectors()
        {
            var _directors = new List<Director>();
            using (var context = new Context())
            {
                _directors = context.DirectorContext.ToList<Director>();
            }
            return _directors;
        }

        public static void AddToDB(Movie movie)
        {
            using (var context = new Context())
            {
                context.MovieContext.Add(movie);
                context.SaveChanges();
            }
        }

        public static void AddToDB(Director director)
        {
            using (var context = new Context())
            {
                context.DirectorContext.Add(director);
                context.SaveChanges();
            }
        }
    }
}