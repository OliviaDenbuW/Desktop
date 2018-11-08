using System.ComponentModel.DataAnnotations;

namespace DemoASPNETRepetitionMVC.Models
{
    public class Person
    {
        [Required(ErrorMessage ="Namn är obligatoriskt")]
        [StringLength(50,ErrorMessage ="Max 50 tecken i namnet")]
        public string Name { get; set; }

        public string Email { get; set; }

        public int Category { get; set; }
    }
}
