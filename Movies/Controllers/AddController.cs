using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class AddController : Controller
    {
        private static List<Director> directors = new List<Director>();
        
        [HttpGet]
        public ActionResult AddMovie()
        {
            directors = DbOperations.GetDirectors();
            var model = new MovieAddView
            {
                Movie = new Movie(),
                Directors = directors
            };
            return View(model);
        }
        
        [HttpPost]
        public ActionResult AddMovie(MovieAddView model)
        {
            if (!ModelState.IsValid)
            {
                model.Directors = directors;
                return View(model);
            }
            DbOperations.AddToDB(model.Movie);
            return RedirectToAction("Search", "Home");
        }


        [HttpGet]
        public ActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDirector(Director model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            DbOperations.AddToDB(model);
            return RedirectToAction("Directors", "Home");
        }
    }
}