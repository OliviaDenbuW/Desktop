using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Uppg1Validering.Models
{
    public class Datum
    {
        [Required (ErrorMessage = "År är obligatoriskt")]
        public int År { get; set; }

        [Required (ErrorMessage =  "Månad är obligatoriskt")]
        [Range (1, 12, ErrorMessage = "Månad ska vara mellan 1-12")]
        public int Månad { get; set; }

        [Required (ErrorMessage = "Dag är obligatoriskt")]
        [Range (1, 31, ErrorMessage = "Dag ska vara mellan 1-31")]
        public int Dag { get; set; }
    }
}
