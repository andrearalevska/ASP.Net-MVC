using ClassCode.Models;
using ClassCode.ViewModels;

namespace ClassCode.Mappers
{
    public static class OrderMapper
    {
        public static OrderListViewModel OrderToOrderListViewModel(Order orderdb)
        {
            return new OrderListViewModel
            {
                PizzaName = orderdb.Pizza.Name,
                UserFullName = $"{orderdb.User.FirstName} {orderdb.User.LastName}"
            };
        }

        public static OrderDetailsViewModel OrderToOrderDetailsViewModel(Order orderdb)
        {
            return new OrderDetailsViewModel
            {
                PizzaName = orderdb.Pizza.Name,
                UserFullName = $"{orderdb.User.FirstName} {orderdb.User.LastName}",
                OrderPrice = orderdb.Pizza.Price + 50,
                PaymentMethod = orderdb.PaymentMethod.ToString()

            };
        }
    }

}
