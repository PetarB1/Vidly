using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie { Name = "Shrek" });
            movies.Add(new Movie { Name = "Harry Potter" });

            return View(movies);
        }
    }
}