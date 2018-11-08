using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Loops_Mosh_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to count how many numbers
            //between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.
            int räknare = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    räknare++;
                }
            }
            Console.WriteLine(räknare);
            Console.ReadLine();
        }
    }
}
