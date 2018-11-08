using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTomasos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is mandatory")]
        [Display (Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }
    }
}
