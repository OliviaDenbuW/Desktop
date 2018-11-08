using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg9_ManEllerKvinna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Personnummer: ");
            string personnummer = Console.ReadLine();

            //  911122-0423
            //  012345678910
            //Hitta näst sista siffran och jämföra
            string strNrThatDecidesGender = personnummer.Substring(9, 1);
            int nrThatDecidesGender = int.Parse(strNrThatDecidesGender);

            if (nrThatDecidesGender % 2 == 0)
            {
                Console.WriteLine("WE RUN THE WORLD");
            }
            else
            {
                Console.WriteLine("SUCKER");
            }
            Console.ReadLine();
        }

    }
}
