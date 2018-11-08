using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta4_Företag
{
    class Person
    {
        public string Personnummer { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }

        public Person(string personnummer, string förnamn, string efternamn)
        {
            this.Personnummer = personnummer;
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
        }
    }
}
