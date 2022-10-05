using System;
using System.ComponentModel.DataAnnotations;

namespace Foodmoji_Domain.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public string picture { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double totalPrice { get; set; }

      
      
    }
}
