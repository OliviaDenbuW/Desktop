using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTomasos.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is mandatory")]
        [Display(Name = "Street address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Postal number is mandatory")]
        [Display(Name = "Postal number")]
        public string PostalNumber { get; set; }

        [Required(ErrorMessage = "Postal area is mandatory")]
        [Display(Name = "Postal area")]
        public string PostalArea { get; set; }

        [Required(ErrorMessage = "Email is mandatory")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is mandatory")]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Username is mandatory")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }
    }
}
