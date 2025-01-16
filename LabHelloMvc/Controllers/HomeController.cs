using System.Diagnostics;
using LabHelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabHelloMvc.Controllers
{
    public class HomeController : Controller
    {
        // Constructor
        public HomeController()
        {

        }

        public IActionResult Index()
        {

            // Create a person
            Person person = new Person();
            person.FirstName = "Laura";
            person.LastName = "Silva";


            return View(person);
        }

        // Display the details of a person

        public IActionResult Privacy()
        {

            return View();
        }

    }
}
