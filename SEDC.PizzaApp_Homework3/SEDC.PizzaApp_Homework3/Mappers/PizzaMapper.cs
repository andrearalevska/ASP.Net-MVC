using SEDC.PizzaApp.Models;
using SEDC.PizzaApp_Homework3.ViewModels;

namespace SEDC.PizzaApp_Homework3.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                PizzaName = pizza.Name,
                PizzaPrice = pizza.Price,
                IsPromotion = pizza.IsOnPromotion
            };
        }
    }
}
