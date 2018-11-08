using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Uppg2Validering.Models
{
    public class Person
    {
        [Required (ErrorMessage = "Användarnamn är obligatoriskt")]
        //[Range (5, 12, ErrorMessage = "Anvandarnamn måste vara mellan 5-12 tecken")]
        [RegularExpression("^[\\s\\S]{0,8}$", ErrorMessage = "Max 8")] 
        [StringLength (12, ErrorMessage = "Användarnamn har maxlängd 12 tecken"), MinLength(5, ErrorMessage = "Användarnamn har minlängd 5 tecken")]
        public string Anvandarnamn { get; set; }

        [Required(ErrorMessage = "Lösenord är obligatoriskt")]
        [RegularExpression("\\S*(\\S*([a-zA-Z]\\S*[0-9])|([0-9]\\S*[a-zA-Z]))\\S*", ErrorMessage = "Password must contain numbers and letters")]
        public string Losenord { get; set; }

        [Required(ErrorMessage = "Obligatoriskt att verifiera lösenordet")]
        [Compare ("Losenord", ErrorMessage = "Losenord och verifieringslösenord måste vara identiska.")]
        public string VerifieraLosenord { get; set; }

        [Required(ErrorMessage = "Personnummer är obligatoriskt")]
        [RegularExpression("([0-9]{6}-[0-9]{4})|([0-9]{8}-[0-9]{4})", ErrorMessage = "Dåligt format på personnummer")]
        public string Personnummer { get; set; }

        [Required(ErrorMessage = "Email är obligatoriskt")]
        //[EmailAddress (ErrorMessage = "Ogiltig email")]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Ogiltig email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Fel format på email")]

        //. vilket tecken
        //* antal tecken
        public string Email { get; set; }
    }
}
