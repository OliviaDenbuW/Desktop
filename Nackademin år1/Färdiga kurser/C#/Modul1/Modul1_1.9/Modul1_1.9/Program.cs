using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Antal rader: ");
            string indataRader = Console.ReadLine();
            int antalRader = int.Parse(indataRader);

            for (int rad = antalRader; rad > 0; rad--)
            {
                for (int plustecken = 0; plustecken < rad; plustecken++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }

            //for (int rad = 1; rad <= antalRader; rad++)
            //{
            //    for (int plustecken = 1; plustecken <= rad; plustecken++)
            //    {
            //        Console.Write("+");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
