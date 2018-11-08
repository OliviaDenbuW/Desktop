using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils;

namespace TomasosPizzeria.Models
{
    public partial class Kund
    {
        public Kund()
        {
            Bestallning = new HashSet<Bestallning>();
        }


        public int KundId { get; set; }

        [Required(ErrorMessage = "Namn saknas")]
        public string Namn { get; set; }

        [Required(ErrorMessage = "Gatuadress saknas")]
        public string Gatuadress { get; set; }

        [Required(ErrorMessage = "Postnr saknas")]
        public string Postnr { get; set; }

        [Required(ErrorMessage = "Postort saknas")]
        public string Postort { get; set; }

        [EmailAddress(ErrorMessage = "Måste vara en giltig email")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Måste vara en giltig telefon number")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Användarnamn saknas"), DisplayName("Användarnamn")]
        public string AnvandarNamn { get; set; }

        [Required(ErrorMessage = "Lösenord saknas"), DisplayName("Lösenord")]
        public string Losenord { get; set; }

        public ICollection<Bestallning> Bestallning { get; set; }
    }
}
