using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg6
{
    class Program
    {
        static void Main(string[] args)
        {
            Villa villa = new Villa();
            Lägenhet lägenhet = new Lägenhet();

            villa.Taxeringsvärde = 126;
            lägenhet.Taxeringsvärde = 1000000;

            Console.WriteLine("Fastighetsavgift för villan är {0}kr", villa.Fastighetsavgift());
            Console.WriteLine("Fastighetsavgift för lägenheten är {0}kr", lägenhet.Fastighetsavgift());
            Console.ReadLine();
        }
    }
}
