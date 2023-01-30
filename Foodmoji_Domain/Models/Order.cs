using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Foodmoji_Domain.Models
{
    public class Order : AuditEntity<int>
    {
        
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please enter the quantity for this order")]
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        //Foreign key

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


    }
}
