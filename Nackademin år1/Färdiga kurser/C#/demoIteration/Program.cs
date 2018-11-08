using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //// for-loop - Counting
            for (int count = 10; count >= 0; count--)
            {
                Console.WriteLine(count);
            }
            Console.ReadLine();

            //int counter = 10;
            //while (counter >= 0)
            //{
            //    Console.WriteLine(counter);
            //    //counter = counter - 1;
            //    counter--;
            //}
            //Console.ReadLine();

            //Console.Write("Skriv en text: ");
            //var text = Console.ReadLine();

            //foreach (var bokstav in text)
            //{
            //    Console.Write(" " + bokstav);
            //}

            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.Write(" " + text[i]);
            //}

            //Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i+1; j <=5; j++)
                {
                    Console.WriteLine("Lag " + i + " - Lag " + j);
                }
            }

        }
    }
}
