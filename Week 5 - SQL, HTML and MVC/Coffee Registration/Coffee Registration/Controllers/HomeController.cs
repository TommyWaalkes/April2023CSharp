using Coffee_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee_Registration.Controllers
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
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Result(User u)
        {
            if (u.Password.ToLower().Contains("password"))
            {
                return RedirectToAction("Failed");
            }
            else
            {
                return View(u);
            }
        }

        public IActionResult Failed()
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