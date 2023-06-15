using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
             new Pizza()
            {
                Id = 1,
                Name = "Capri",
                Price = 350,
                IsOnPromotion = true,
            },
            new Pizza()
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 400,
                IsOnPromotion = false,
            }
        };

        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                CustomerName = "Kristijan",
                CustomerAddress = "Meckin Kamen 18a-1/23",
                Price = 550,
                IsDelivered = true

            },
            new Order()
            {
                Id = 2,
                CustomerName = "Petar",
                CustomerAddress = "Dimitar Todorovski br. 9",
                Price = 650,
                IsDelivered = false

            }
        };

    }
}
    