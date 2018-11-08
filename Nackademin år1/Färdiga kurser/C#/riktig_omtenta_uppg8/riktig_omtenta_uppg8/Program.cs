using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Stockholm", "Göteborg", "Malmö", "Köpenhamn", "London" };

            var resultat = from ch in cities
                           where Char.IsLetter(ch).ToString
                           select ch;



            Console.WriteLine(resultat);


            Console.ReadLine();
        }
    }
}
