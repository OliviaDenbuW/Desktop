using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // String kan behandlas som en array och char (men inte tvärtom)
            string hej = "Hello";
            char[] hejchararray= { 'H', 'e', 'l', 'l', 'o'};
 
            Console.WriteLine($"hej Length:{hej.Length} hej[0]:{hej[0]}");

            // Read/Write
            Console.WriteLine("Antal personer: ");
            int antalPersoner = int.Parse(Console.ReadLine());

            double[] åldrar = new double[antalPersoner];

            for (int i = 0; i < åldrar.Length; i++)
            {
                Console.Write($"Ålder på person {i}: ");
                åldrar[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Åldrar: " + åldrar);  //FEL - Skriver ut typen.

            // Jagged Array - En Array av en Array
            int[][] jagged = new int[4][];

            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 1, 2 };
            jagged[2] = new int[] { 1, 2, 3, 4 };
            jagged[3] = new int[] { 4 };

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write($"Rad {i}: ");

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]+ " ");
                }

                Console.WriteLine();
            }

        }
    }
}
