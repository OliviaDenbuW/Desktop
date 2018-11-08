using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bensinförbrukning: (miles/gallon) ");
            string indata = Console.ReadLine();

            double milesPerGallon = double.Parse(indata);
            double literPerMil = 3.785 / milesPerGallon / 1.609 * 10;

            Console.WriteLine("{0} l/mil", literPerMil);
            Console.ReadLine();
        }
    }
}
