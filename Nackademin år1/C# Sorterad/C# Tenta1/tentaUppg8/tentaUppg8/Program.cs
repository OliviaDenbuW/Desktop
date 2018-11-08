using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] housePricesInDollars = { 3.4, 5.2, 1.2, 0.7, 2.6, 2.7, 3.0 };
            double[] housePricesInSEK = new double[7];

            var sökResultatÖverMil = housePricesInDollars.TakeWhile(n => n > 1.0);
            
            foreach (var n in sökResultatÖverMil)
            {
                Console.WriteLine(n);
            }

            var sökResultatGånger = sökResultatÖverMil.Take()

            Console.ReadLine();
        }
    }
}
