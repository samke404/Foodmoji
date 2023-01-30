using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodmoji_Domain.Models
{
    public class Product : AuditEntity<int>
    {
        

        [Required (ErrorMessage = "Please provide a valid product name")]
        public string ProductName { get; set; }
        public string Picture { get; set; }

        [MinLength(10), Required(ErrorMessage = "Please enter a description for the product")]
        public string ProductDescription { get; set; }

        [MaxLength(5), Required(ErrorMessage = "Enter the quantity of the product available in store")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price of the product is required")]
        public double Price { get; set; }
       // public double TotalPrice { get; set; }



    }
}
