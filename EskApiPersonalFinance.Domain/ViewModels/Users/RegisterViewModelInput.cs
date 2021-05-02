using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Domain.ViewModels.Users
{
    public class RegisterViewModelInput
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(2, ErrorMessage = "Minimun 2 characters")]
        [MaxLength(150, ErrorMessage = "Maximun 150 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Minimun 2 characters")]
        [MaxLength(150, ErrorMessage = "Maximun 150 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MinLength(2, ErrorMessage = "Minimun 2 characters")]
        [MaxLength(100, ErrorMessage = "Maximun 150 characters")]
        [EmailAddress(ErrorMessage = "E-mail invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
