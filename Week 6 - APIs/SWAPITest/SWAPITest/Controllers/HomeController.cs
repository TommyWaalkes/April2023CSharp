using Microsoft.AspNetCore.Mvc;
using SWAPIExample.Models;
using System.Diagnostics;

namespace SWAPIExample.Controllers
{
    public class HomeController : Controller
    {
        //Lets make 2 views: 1) Input for an Id for SWPerson 2) Details of the choosen SWPerson 
        private readonly ILogger<HomeController> _logger;
        DonutDAL donutAPI = new DonutDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Result> donuts = donutAPI.GetDonuts().results.ToList();
            return View(donuts);
        }

        public IActionResult Details(int Id)
        {
            //SWPerson sp = SWapi.GetPerson(Id);
            DonutDetails result = donutAPI.GetDonutDetails(Id);
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}