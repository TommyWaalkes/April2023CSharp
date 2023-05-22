using Microsoft.AspNetCore.Mvc;
using SWAPIExample.Models;
using System.Diagnostics;

namespace SWAPIExample.Controllers
{
    public class HomeController : Controller
    {
        //Lets make 2 views: 1) Input for an Id for SWPerson 2) Details of the choosen SWPerson 
        private readonly ILogger<HomeController> _logger;
        SWDAL SWapi = new SWDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int Id)
        {
            SWPerson sp = SWapi.GetPerson(Id);

            return View(sp);
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