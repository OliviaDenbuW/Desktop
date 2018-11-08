using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaDemoRepetitionMVC2.Models
{
    public class Person
    {
        public string Namn { get; set; }
        public string Email { get; set; }

        [Compare("Email", ErrorMessage = "Email och verifieringsemail måste vara identiska.")]
        public string VerifieradEmail { get; set; }
        public int PersonTyp { get; set; }

    }
}
