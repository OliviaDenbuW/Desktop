using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Array_Kvadratrötter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array med 100st kvadratrötter - Kommer finnas DECIMALTAL
            double[] array = new double[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Sqrt(i);
            }

            for (int i = 0; i < array.Length; i++)
            {
                double kvadratrot = Math.Sqrt(i);
                Console.WriteLine(kvadratrot);
            }
            //foreach (double kvadratrot in array)
            //{
            //    Console.WriteLine(kvadratrot);
            //}
            Console.ReadLine();
        }
    }
}
