using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Domain.Models
{
    public class AccountRole
    {
        [Key]

        public int Id { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
