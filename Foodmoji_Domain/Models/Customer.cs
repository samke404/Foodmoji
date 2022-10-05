using System;
using System.ComponentModel.DataAnnotations;

namespace Foodmoji_Domain.Models
{
    public class Customer
    {
        [Key]
        public int customerId { get; set; }

        [MaxLength(100)]
        public string firstname { get; set; }

        [MaxLength(100)]
        public string lastname { get; set; }
        public string cellphoneNo { get; set; }
        public string email { get; set; }
        public string address { get; set; }

      
    }
}
