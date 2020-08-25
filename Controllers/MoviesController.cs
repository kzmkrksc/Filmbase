using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmBase.Models;
using FilmBase.ViewModels;

namespace FilmBase.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        //disposing
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //list of movies
        [HttpGet]
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        //Create Movie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit (int id)
        {
            return Content("id = " + id);
        }

       

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public  ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }


}