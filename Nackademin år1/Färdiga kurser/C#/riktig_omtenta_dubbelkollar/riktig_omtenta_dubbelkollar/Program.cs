using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_dubbelkollar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { -9, 3, 7, 2, 1, 3, 4, 4, 2, 5, 75, 4, 2, 67 };

            var resultat = (from x in tal
                            where (x % 2 != 0)
                            orderby x descending
                            select x).Distinct();

            foreach (var t in resultat)
            {
                Console.WriteLine(t);
            }

            Console.ReadLine();
        }
    }
}
