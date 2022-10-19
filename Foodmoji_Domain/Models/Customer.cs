using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodmoji_Domain.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Firstname { get; set; }

        [MaxLength(100)]
        public string Lastname { get; set; }
        public string CellphoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        //Foreign Key

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
