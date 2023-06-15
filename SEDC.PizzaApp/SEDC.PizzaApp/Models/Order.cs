namespace SEDC.PizzaApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int Price { get; set; }
        public bool IsDelivered { get; set; }
    }
}
