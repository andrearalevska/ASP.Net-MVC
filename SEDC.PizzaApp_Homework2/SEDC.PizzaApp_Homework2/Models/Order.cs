﻿using ClassCode.Models.Enums;
using SEDC.PizzaApp.Models;

namespace ClassCode.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public PaymentMethod PaymentMethod { get; set; }


    }
}