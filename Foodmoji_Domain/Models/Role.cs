using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Domain.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [MaxLength(100)]
        public string RoleName { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
       /* public virtual List<Account> Accounts { get; set; }

        public Role()
        {
            Accounts = new List<AccountRole>();
        }*/
    }
}
