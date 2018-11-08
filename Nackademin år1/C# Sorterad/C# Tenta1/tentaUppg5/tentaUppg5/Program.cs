using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg5
{
    class Program
    {
        static void Main(string[] args)
        {
            //911122, "Olivia", "Denbu"
            Medlem person1 = new Medlem();
            person1.Förnamn = "Olivia";

            Klubb klubb = new Klubb("HejsanAB", "Rudsjövägen 51", "NACKA", "www.hejsan.com", person1);


            Medlem person2 = new Medlem();
            Medlem person3 = new Medlem();

            klubb.Ordförande = person2;
            int antalMedlemmar = klubb.AntalMedlemmar();

            Console.WriteLine(antalMedlemmar);
            Console.ReadLine();
        }
    }
}
