using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace uppg1FormulärModellEF.Models
{
    public partial class UserLogin
    {
        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }

        [Required, MaxLength(30)]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string City { get; set; }
    }
}
