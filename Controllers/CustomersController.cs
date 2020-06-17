using FilmBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmBase.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //Create Hard coded customer list - later will be deleted after DB entegration completed.
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Ali Veli" },
                new Customer { Id = 2, Name = "Binali Sesigüzel" },
                new Customer { Id = 3, Name = "Şahika Sulu" },
                new Customer { Id = 4, Name = "Ayşe Şenşakrak" },
                new Customer { Id = 5, Name = "Cavidan Civelek" }
            };
        }
    }
}