using Microsoft.AspNetCore.Mvc;

namespace EFLecture.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
