using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Domain.Models
{
    public class Role : AuditEntity<int>
    {
        
        [MaxLength(100), Required(ErrorMessage = "Nmae is required")]
        public string Name { get; set; }

        [MinLength(50), Required(ErrorMessage = "Please provide a brief description of the role")]
        public string Description { get; set; }

    }
}
