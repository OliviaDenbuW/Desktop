using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace omtentaASPNET.Models
{
    public class User
    {
        [Required(ErrorMessage = "Namn är obligatoriskt")]
        public string Namn { get; set; }

        [Required(ErrorMessage = "Ålder är obligatoriskt")]
        [Range(13, 99, ErrorMessage = "Ålder måste vara ett siffervärde mellan 13 och 99")]
        public int Ålder { get; set; }

        [Required(ErrorMessage = "Favoritårstid är obligatoriskt")]
        public string Favoritårstid { get; set; }

        [Required(ErrorMessage = "Favoritgodis är obligatoriskt")]
        public string Favoritgodis { get; set; }
    }
}
