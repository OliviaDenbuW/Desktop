using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace uppg2FormulärModellEF.Models
{
    public partial class UserLogin
    {
        public int UserId { get; set; }
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
