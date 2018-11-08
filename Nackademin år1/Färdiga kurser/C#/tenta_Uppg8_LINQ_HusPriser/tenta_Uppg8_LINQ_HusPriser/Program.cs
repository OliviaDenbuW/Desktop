using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg8_LINQ_HusPriser
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] housePricesInDollars = { 3.4, 5.2, 1.2, 0.7, 2.6, 2.7, 3.0 };

            var resultLINQ = from dollar in housePricesInDollars
                         where dollar > 1
                         select dollar * 8;


            double[] housePricesInSEK = housePricesInDollars.Select(dollar =>
            {
                if (dollar > 1) { dollar = dollar * 8; }
                return dollar;
            }).ToArray();

            //double[] housePriceInSEK = Array.ConvertAll(housePricesInDollars, dollar => dollar * 8);
            //double[] housePricesInSEK = Array.ConvertAll(housePricesInDollars, x => x * 8);
            //var resultLambda = housePricesInDollars.Where(dollar => dollar > 1);

            foreach (var sek in housePricesInSEK)
            {
                Console.Write(sek + ", ");
            }

            Console.WriteLine();
            foreach (var dollar in resultLINQ)
            {
                Console.WriteLine(dollar);
            }

            //double[] housePricesInSEK;

            Console.ReadLine();
        }
    }
}
