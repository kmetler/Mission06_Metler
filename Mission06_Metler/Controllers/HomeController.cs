using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Metler.Models;

namespace Mission06_Metler.Controllers
{
    public class HomeController : Controller
    {
        private NewMovieContext _context;

        public HomeController(NewMovieContext temp) //Constuctor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(NewMovie response)
        {
            _context.Movies.Add(response); //Add record to the database
            _context.SaveChanges();

            return View("Confirmation");
        }
    }
}
