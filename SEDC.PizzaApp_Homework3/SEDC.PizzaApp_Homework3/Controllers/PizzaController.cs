using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp_Homework3.Mappers;
using SEDC.PizzaApp_Homework3.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetAllPizzas()
        {
            List<Pizza> pizzasDb = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaViewModels = pizzasDb.Select(x=> PizzaMapper.PizzaToPizzaViewModel(x)).ToList();
            return View(pizzaViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error", "Home");
            }

            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return View("ResourceNotFound");
            }

            PizzaViewModel pizzaViewModel = PizzaMapper.PizzaToPizzaViewModel(pizza);
            return View(pizzaViewModel);
        }
    }
}