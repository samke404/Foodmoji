using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodmoji_Domain.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Picture { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }



    }
}
