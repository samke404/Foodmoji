using Foodmoji_Application.ViewModels.Account;
using Foodmoji_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
 
namespace Foodmoji_Application.Helpers.Extensions
{
    public static class AccountExtensions
    {
        public static Account ToEntity(this RegisterAccountViewModel model)
        {
            return new Account {
                FirstName = model.FirstName,
                Surname = model.Surname,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Password = model.Password
            };
        }
    }
}
