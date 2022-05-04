using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numberOfTimes)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumberOfTimes"] = numberOfTimes;
            return View();
        }
    }
}