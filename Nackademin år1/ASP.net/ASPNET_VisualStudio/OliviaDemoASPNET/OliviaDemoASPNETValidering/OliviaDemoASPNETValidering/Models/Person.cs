using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OliviaDemoASPNETValidering.Models
{
    public class Person
    {
        [DisplayName ("Skriv ditt namn här:")]
        [Required (ErrorMessage = "Namn är obligatoriskt")]
        [StringLength(40, ErrorMessage ="Namn får vara max 40 bokstäver")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Email är obligatoriskt")]
        [EmailAddress (ErrorMessage = "Ogiltig email-address")]
        public string Email { get; set; }

        [DisplayName ("Skriv ditt personnummer här:")]
        [Range (1, 99, ErrorMessage = ("Ogiltigt födelseår"))]
        public int? BirthYear { get; set; }
    }
}
