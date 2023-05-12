using CoffeeProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeProduct.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductDbContext _context;
        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> allProducts = _context.Products.ToList();
            return View(allProducts);
        }

        public IActionResult Detail(int productId)
        {
            Product product = _context.Products.FirstOrDefault(p=> p.Id == productId);
            return View(product);
        }

        // Filter Products example, not implemented
        public IActionResult Filter(int minPrice)
        {
            List<Product> ExpensiveProducts = _context.Products.Where(p => p.Price > minPrice).ToList();
            return View(ExpensiveProducts);
        }
    }
}
