using SEDC.PizzaApp_Homework2.Models.Enums;

namespace SEDC.PizzaApp_Homework2.ViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PizzaSize { get; set; }
        public bool HasExtras { get; set; }

    }
}
