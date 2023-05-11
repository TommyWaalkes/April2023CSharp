using EFLecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFLecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeDbContext _employeeDbContext;

        public HomeController(ILogger<HomeController> logger, EmployeeDbContext context)
        {
            _logger = logger;
            _employeeDbContext = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            List<Employee> result = _employeeDbContext.Employees.ToList();
            return View(result);
        }

        public IActionResult Confirmation(Employee e)
        {
            //changes start transaction
            _employeeDbContext.Employees.Add(e);
            //saves run transaction
            _employeeDbContext.SaveChanges();
            //if anything in transaction fails, no changes go through
            return View(e);
        }

        public IActionResult AddEmployee(Employee e)
        {
            _employeeDbContext.Employees.Add(e);
            _employeeDbContext.SaveChanges();
            return RedirectToAction("Employees");
        }

        public IActionResult DeleteEmployee(int id)
        {
            Employee e = _employeeDbContext.Employees.FirstOrDefault(e => e.Id == id);
            _employeeDbContext.Employees.Remove(e);
            _employeeDbContext.SaveChanges();

            return RedirectToAction("Employees");
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