using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        private static List<Movie> lastmovies = new List<Movie>();
        private static List<Director> directors = new List<Director>();
       
        public ActionResult Index()
        {
            var lastmovies = DbOperations.GetMovies();
            var last = lastmovies.OrderByDescending(m => m.Id).Take(5);
            return View(last);
        }
        
        public ActionResult Search(string searchString)
        {
            var movies = DbOperations.GetMovies();
            if (String.IsNullOrEmpty(searchString))
            {
                return View("Search", movies);
            }
            var m = movies.Where(s => s.Title.ToLower().Contains(searchString.ToLower()));
            return View(m);
        }

        public ActionResult Directors()
        {
            ViewBag.Message = "Directors of movies in this catalog";
            directors = DbOperations.GetDirectors();
            return View(directors);
        }

        public ActionResult Details(int? id)
        {
            ViewBag.Message = "Movie Details";
            lastmovies = DbOperations.GetMovies();
            var m = lastmovies.Where(p => p.Id == id).FirstOrDefault();
            return View(m);
        }
    }
}