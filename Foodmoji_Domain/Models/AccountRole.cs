using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Domain.Models
{
    public class AccountRole : AuditEntity<int>
    {
       
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        // Public List<Account> Accounts { get: set} = new List<Account>(); lookup

        public int RoleId { get; set; }
        public virtual Role Role { get; set; } // = new Role(); lookup
    }
}
