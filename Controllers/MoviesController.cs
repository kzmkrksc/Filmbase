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
        //list of movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = GetMovies();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Fast and Furious" },
                new Movie { Id = 2, Name = "Lord of the Rings: The Fellowship of the Ring" },
                new Movie { Id = 3, Name = "Gladiator" },
                new Movie { Id = 4, Name = "Inception" },
                new Movie { Id = 5, Name = "Prestige" },
                new Movie { Id = 6, Name = "Illusionist" },
                new Movie { Id = 7, Name = "Midnight in Paris" },
                new Movie { Id = 8, Name = "Avengers: Endgame" },
                new Movie { Id = 9, Name = "Braveheart" },
                new Movie { Id = 10, Name = "Inglorious Basterds" },
                new Movie { Id = 11, Name = "Django" },
                new Movie { Id = 12, Name = "Hateful Eight" },
                new Movie { Id = 13, Name = "Kill Bill: Vol I" }

            };
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