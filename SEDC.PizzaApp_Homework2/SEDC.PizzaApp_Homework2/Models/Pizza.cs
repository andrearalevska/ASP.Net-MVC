using SEDC.PizzaApp_Homework2.Models.Enums;

namespace SEDC.PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize PizzaSize { get; set; }   
        public decimal Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public bool HasExtras { get; set; }
    }
}