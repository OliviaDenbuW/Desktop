using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie;

            do
            {
                Console.Write("Radie: ");
                string indata = Console.ReadLine();
                radie = double.Parse(indata);

                if (radie <= 0)
                {
                    Console.WriteLine("Felaktig radie");
                    Console.WriteLine();
                }

            } while (radie <= 0);
            

            double pi = Math.PI;

            double volym = (4 * pi * radie * radie * radie) / 3;
            double area = 4 * pi * radie * radie;

            Console.WriteLine();
            Console.WriteLine("Volym: {0} v.e", volym);
            Console.WriteLine("Area: {0} a.e", area);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
