using ClassCode.Mappers;
using ClassCode.Models;
using ClassCode.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp;

namespace ClassCode.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult GetAllOrders()
        {
            List<Order> ordersdb = StaticDb.Orders;

            List<OrderListViewModel> orderListViewModels = ordersdb.Select(x => OrderMapper.OrderToOrderListViewModel(x)).ToList();
            return View(orderListViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                RedirectToAction("Error", "Home");
            }

            Order orderdb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orderdb == null)
            {
                RedirectToAction("Error", "Home");
            }

            ViewData["Title"] = "Order Details";
            ViewData["DateTime"] = DateTime.Now.ToString();

            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderdb);

            ViewBag.User = orderdb.User;
            return View(orderDetailsViewModel);

        }
    }
}