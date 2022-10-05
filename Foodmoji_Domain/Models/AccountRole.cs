using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Domain.Models
{
    public class AccountRole
    {
        public int AccountId { get; set; }
       // public virtual Account Account;

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
