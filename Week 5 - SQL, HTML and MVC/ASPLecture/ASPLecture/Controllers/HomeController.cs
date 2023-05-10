using ASPLecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPLecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CatForm()
        {
            return View();
        }

        public IActionResult CatResult(Cat result)
        {
            return View(result);
        }

        public IActionResult Details()
        {
            ViewData["Name"] = "Justin";
            ViewBag.age = 25;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}