using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using uppg1FormulärEFRep.Models;

namespace uppg1FormulärEFRep.ViewModels
{
    public class NewUserViewModel
    {
        public UserLogin MyUser { get; set; }

        //[Compare (otherProperty: MyUser.Password, ErrorMessage = "Passwords do not match")]
        public int MyProperty { get; set; }
        public string VerifiedPassword { get; set; }
    }
}
