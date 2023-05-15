using AdoptionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdoptionMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AdoptionContext db = new AdoptionContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pet> pets = db.Pets.ToList();
            //Use linq to filter out duplicate breeds 
            List<Pet> filtered  = pets.DistinctBy(p => p.Breed).ToList();
            return View(filtered);
        }

        public IActionResult Result(string breed)
        {
            List<Pet> pets = db.Pets.Where(p => p.Breed == breed).ToList();
            return View(pets);
        }

        public IActionResult Adopt(int Id)
        {
            Pet p = db.Pets.Find(Id);
            db.Pets.Remove(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        //For add we will do 2 actions: one to display the view, one to handle input from the form on the view 

        //This action displays the view 
        public IActionResult Add()
        {
            return View();
        }

        //This action handles the input from the add pet form 
        [HttpPost] //Post is a type of HTTP call, usually used for adding a new item to a database
                   //I'm putting it here to tell .Net this action is used for adding to the DB and NOT for displaying a view
        public IActionResult Add(Pet p)
        {
            db.Pets.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Animal()
        {
            Pet p = db.Pets.First();
            return View(p);
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