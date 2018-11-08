using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta1_Fastigheter
{
    class Program
    {
        static void Main(string[] args)
        {
            Villa villa = new Villa();
            villa.TaxeringsVärde = 1000000000;

            Lägenhet lägenhet = new Lägenhet();
            lägenhet.TaxeringsVärde = 1000;

            Console.WriteLine(villa.FastighetsAvgift());
            Console.WriteLine(lägenhet.FastighetsAvgift());
            Console.ReadLine();
        }
    }
}
