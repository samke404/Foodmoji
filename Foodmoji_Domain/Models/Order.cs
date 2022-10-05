using System;
using System.ComponentModel.DataAnnotations;

namespace Foodmoji_Domain.Models
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }
        public DateTime date { get; set; }
        public int quantity { get; set; }
        public double totalPrice { get; set; }
        
      
    }
}
