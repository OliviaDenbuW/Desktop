using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uppg6FormulärCV.Models
{
    public class Person
    {
        [Required (ErrorMessage = "Namn är obligatoriskt")]
        public string Namn { get; set; }

        [Required(ErrorMessage = "Email är obligatoriskt")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gatuadress är obligatoriskt")]
        public string Gatuadress { get; set; }

        [Required(ErrorMessage = "Postnr är obligatoriskt")]
        public int Postnr { get; set; }

        [Required(ErrorMessage = "Ort är obligatoriskt")]
        public string Ort { get; set; }

        [Required(ErrorMessage = "Telefon är obligatoriskt")]
        public int Telefon { get; set; }

        public string Utbildningsbeskrivning { get; set; }

        [Required(ErrorMessage = "Region är obligatoriskt")]
        public string Region { get; set; }

        public string Körkortsstatus { get; set; }

        public string Hobby { get; set; }
    }
}
