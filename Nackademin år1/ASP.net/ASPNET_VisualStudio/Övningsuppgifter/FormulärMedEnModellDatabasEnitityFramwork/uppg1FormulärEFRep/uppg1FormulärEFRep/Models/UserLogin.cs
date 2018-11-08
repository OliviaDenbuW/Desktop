using System;
using System.Collections.Generic;

namespace uppg1FormulärEFRep.Models
{
    public partial class UserLogin
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
