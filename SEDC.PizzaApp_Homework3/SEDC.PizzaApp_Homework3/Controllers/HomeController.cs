using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp_Homework3.Mappers;
using SEDC.PizzaApp_Homework3.Models;
using SEDC.PizzaApp_Homework3.ViewModels;
using System.Diagnostics;

namespace SEDC.PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //http://localhost:[port]/AboutUs
        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SeeUsers()
        {

            List<User> users = StaticDb.Users.ToList();
            List<UserViewModel> userViewModels = users.Select(x => UserMapper.UserToUserViewModel(x)).ToList();

            return View(userViewModels);


        }
    }
}