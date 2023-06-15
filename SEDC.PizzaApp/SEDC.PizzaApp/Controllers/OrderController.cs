using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order>orders = StaticDb.Orders;
            return View(orders);
        }
        public IActionResult Details(int? id)
        {  
            if (id == null)
            {
                return new EmptyResult();
            }
            
            Order order = StaticDb.Orders.FirstOrDefault(o => o.Id == id);

            if(order == null)
            {
                return new EmptyResult();
            }
            
            return View(order);

        }
        public IActionResult JsonData()
        {
            List<Order> orders = StaticDb.Orders;
            return new JsonResult(orders);
        }
        [Route("ReturnToHome")]
        public IActionResult ReturnToHome() 
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
