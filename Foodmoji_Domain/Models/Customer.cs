using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodmoji_Domain.Models
{
    public class Customer : AuditEntity<int>
    {
      

        [MaxLength(100), Required(ErrorMessage = "Name is required")]
        public string Firstname { get; set; }

        [MaxLength(100), Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }

        [Required, MaxLength(15), Phone]
        public string CellphoneNo { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
