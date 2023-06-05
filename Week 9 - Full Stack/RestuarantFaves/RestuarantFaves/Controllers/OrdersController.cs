using Microsoft.AspNetCore.Mvc;
using RestuarantFaves.Models;

namespace RestuarantFaves.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        OrderContext db = new OrderContext();

        [HttpGet]
        public List<Order> Orders()
        {
            return db.Orders.ToList();
        }
        [HttpGet("{id}")]
        public Order GetOrder(int id) {
            Order o = db.Orders.Find(id);

            return o;
        }

        [HttpPost]
        public void CreateOrder(Order newOrder)
        {
            db.Orders.Add(newOrder);
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteOrder(int id)
        {
            Order o = db.Orders.Find(id);
            db.Orders.Remove(o);
            db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void UpdateOrder(Order newOrder, int id) {
            newOrder.id = id;
            db.Orders.Update(newOrder);
            db.SaveChanges();
        }

        
    }
}
