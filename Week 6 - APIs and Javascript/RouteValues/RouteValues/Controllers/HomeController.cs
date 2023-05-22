using Microsoft.AspNetCore.Mvc;
using RouteValues.Models;
using System.Diagnostics;

namespace RouteValues.Controllers
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
            //We're gonna use this list as our database 
            List<Student> students = new List<Student>()
            {
                new Student() {Age= 19, Grade=80,Id=1, Name="Jimmy" }, 
                new Student() {Age= 25, Grade = 75.5, Id=2, Name="Sandy"},
                new Student() {Age= 31, Grade = 95, Id=3, Name="Jose"}
            };

            return View(students);
        }

        public IActionResult Details(int Id)
        {
            //We're gonna use this list as our database 
            List<Student> students = new List<Student>()
            {
                new Student() {Age= 19, Grade=80,Id=1, Name="Jimmy" },
                new Student() {Age= 25, Grade = 75.5, Id=2, Name="Sandy"},
                new Student() {Age= 31, Grade = 95, Id=3, Name="Jose"}
            };
            Student selected = students.Where( s=> s.Id ==Id).FirstOrDefault();

            return View(selected);

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