using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DemoASPNETValidering.Models
{
    //Här läggs ALLA valideringsregler. På så sätt kan de köras både på klient och server
    public class Person
    {
        [DisplayName("Skriv in ditt namn")]
        [Required(ErrorMessage ="Namn är obligatoriskt")]
        [StringLength(40,ErrorMessage ="Namn får vara max 40 tecken")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email är obligatiskt")]
        [EmailAddress(ErrorMessage ="Ogiltig emailadress")]
        public string Email { get; set; }

        [DisplayName("Skriv in ditt födelseår")]
        [Range(1,99,ErrorMessage ="Felaktigt födelseår")]

        public int? BirthYear { get; set; }
    }
}
