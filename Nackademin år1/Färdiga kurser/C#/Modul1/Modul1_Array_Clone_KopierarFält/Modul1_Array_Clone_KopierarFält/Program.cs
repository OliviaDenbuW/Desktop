using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Array_Clone_KopierarFält
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar ett TOMT fält
            int[] a = new int[6];

            //Fyller ett annat fält
            int[] b = new int[] { 5, 5, 5, 5 };

            ////Nu kommer variabeln a att referera till SAMMA fält som variabeln b
            //a = b;
            //foreach (var nummer in a)
            //{
            //    Console.WriteLine(nummer);
            //}

            //Tilldela hela FÄLTET b till a måste vi göra en kopia av det fält b refererar till
            a = (int[])b.Clone();

            for (int i = 0; i < a.Length; i++)
            {
                int nummer = a[i];
                Console.WriteLine(nummer);
            }
            Console.ReadLine();
        }
    }
}
