using SEDC.PizzaApp.Models;
using SEDC.PizzaApp_Homework2.ViewModels;

namespace SEDC.PizzaApp_Homework2.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(Pizza pizzadb)
        {
            return new PizzaViewModel()
            {
                Id = pizzadb.Id,
                Name = pizzadb.Name,
                Price = pizzadb.Price,
                PizzaSize = pizzadb.PizzaSize.ToString(),
                HasExtras = pizzadb.HasExtras,
            };
        }
    }
}
