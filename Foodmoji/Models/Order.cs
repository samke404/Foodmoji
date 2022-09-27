using System;

namespace Foodmoji.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public DateOnly date { get; set; }
        public int quantity { get; set; }
        public double totalPrice { get; set; }
        
        public Order()
        {

        }
    }
}
