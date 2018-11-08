using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppg6Formulär.Models
{
    public class Person
    {
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Postort { get; set; }
        public int Postnummer { get; set; }
        public int Mobiltelefon { get; set; }
        public string Email { get; set; }

        public string Utbildningsbeskrivning { get; set; }
        public string Körkort { get; set; }
        public string Region { get; set; }
    }
}
