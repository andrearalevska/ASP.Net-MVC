using SEDC.PizzaApp.Models;
using SEDC.PizzaApp_Homework3.ViewModels;

namespace SEDC.PizzaApp_Homework3.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel UserToUserViewModel(User user)
        {
            return new UserViewModel
            {
                UserFullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
