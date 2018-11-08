using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_SmallestMultiple
{
    class Program
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        static void Main(string[] args)
        {
            int i = 1;

            while(i%2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 || i % 6 != 0 || i % 7 != 0 ||
                i % 8 != 0 || i % 9 != 0 )
            {
                i++;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
