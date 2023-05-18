using Microsoft.AspNetCore.Mvc;
using MockAssessment6.Models;
using System.Diagnostics;

namespace MockAssessment6.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDb2Context db = new EmployeeDb2Context();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            List<Employee> employees = db.Employees.ToList();
            return View(employees);
        }

        public IActionResult RetirementInfo(int id)
        {
            Employee e = db.Employees.Find(id);
            Retirement r = new Retirement(); 
            if(e.Age > 60)
            {
                r.CanRetire = true;
            }
            else
            {
                r.CanRetire = false;
            }
            decimal percent = .6m; 
            r.Benefits = e.Salary * percent;

            return View(r);
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