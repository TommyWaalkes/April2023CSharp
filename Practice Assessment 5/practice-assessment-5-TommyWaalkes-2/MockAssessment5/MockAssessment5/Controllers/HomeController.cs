using Microsoft.AspNetCore.Mvc;
using MockAssessment5.Models;
using System.Diagnostics;

namespace MockAssessment5.Controllers
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

        public IActionResult GetAge()
        {
            return View();
        }

        public IActionResult Result(Person input)
        {
            //Long way for setting the CanDrink and CanDrive Variables
            if(input.Age >= 21)
            {
                //input.CanDrink= true;
            }

            if(input.Age >= 16)
            {
                //input.CanDrink = true;
            }

            return View(input);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}