using System;

namespace Foodmoji_Domain.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public DateTime date { get; set; }
        public int quantity { get; set; }
        public double totalPrice { get; set; }
        
      
    }
}
