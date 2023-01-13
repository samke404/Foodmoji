using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodmoji_Application.ViewModels.Account
{
    public class LoginViewModel
    {
        [MaxLength(100)]
        [Required, EmailAddress(ErrorMessage = "Email address is required, please enter a valid email address")]
        public string Email { get; set; }

        [MaxLength(6), Required(ErrorMessage = "Please enter a password with maximum of 6 characters")]
        public string Password { get; set; }

    }
}
