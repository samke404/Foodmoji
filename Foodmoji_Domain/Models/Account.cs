﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Domain.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public virtual List<AccountRole> Roles { get; set; }

        public Account()
        {
            Roles = new List<AccountRole>();
        }
    }
}
