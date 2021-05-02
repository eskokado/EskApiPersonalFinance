using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Application.ViewModels.Users
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "E-mail is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
