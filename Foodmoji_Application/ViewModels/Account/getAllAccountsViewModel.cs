using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.ViewModels.Account
{
    public class getAllAccountsViewModel
    {
        [MaxLength(50), Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }

        [MaxLength(50), Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        [MaxLength(100)]
        [Required, EmailAddress(ErrorMessage = "Email address is required, please enter a valid email address")]
        public string Email { get; set; }

        [MaxLength(15), Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        [MaxLength(6), Required(ErrorMessage = "Please enter a password with maximum of 6 characters")]
        public string Password { get; set; }

    }
}
