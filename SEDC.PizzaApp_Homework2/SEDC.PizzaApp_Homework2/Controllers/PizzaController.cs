using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp_Homework2.Mappers;
using SEDC.PizzaApp_Homework2.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzasDb = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaViewModel = pizzasDb.Select(x => PizzaMapper.PizzaToPizzaViewModel(x)).ToList();

            return View(pizzaViewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }

            PizzaViewModel pizzaViewModel = PizzaMapper.PizzaToPizzaViewModel(pizza);

            return View(pizzaViewModel);
            
        }
    }
}