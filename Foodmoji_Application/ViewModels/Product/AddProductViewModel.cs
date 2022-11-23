using System.ComponentModel.DataAnnotations;

namespace Foodmoji_Application.ViewModels.Product
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Please provide a valid product name")]
        public string ProductName { get; set; }
        public string Picture { get; set; }

        [MinLength(10), Required(ErrorMessage = "Please enter a description for the product")]
        public string ProductDescription { get; set; }

        [MaxLength(5), Required(ErrorMessage = "Enter the quantity of the product, only 5 products per customer")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price of the product is required")]
        public double Price { get; set; }
        public double TotalPrice { get; set; }
    }
}