using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uppg1FormulärModellEF.Models
{
    public class UserRegistration
    {
        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmedPassword { get; set; }

        [Required, MaxLength(30)]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string City { get; set; }
    }
}
