using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaWeatherApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password comparation is required")]
        [Compare("Password", ErrorMessage = "Passwords dont match")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
