using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nuvarande år: ");
            string indataNuvarandeÅr = Console.ReadLine();
            int nuvarandeÅr = int.Parse(indataNuvarandeÅr);

            Console.Write("Bilens årmodell: ");
            string indataBilensÅrmodell = Console.ReadLine();
            int bilensÅrmodell = int.Parse(indataBilensÅrmodell);

            int ålderBil = nuvarandeÅr - bilensÅrmodell;

            if (ålderBil >= 5 && ålderBil < 25)
            {
                Console.WriteLine("Välj halvförsäkring");
            }
            else if (ålderBil < 5)
            {
                Console.WriteLine("Välj helförsäkring");
            }
            else
            {
                Console.WriteLine("Välj veteranförsäkring");
            }

            Console.ReadLine();
        }
    }
}
