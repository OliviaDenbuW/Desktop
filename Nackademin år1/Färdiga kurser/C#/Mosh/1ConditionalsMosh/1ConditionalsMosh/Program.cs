using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ConditionalsMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Write a nr between 1-10");

            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(input);

            //if(number >= 1 && number <= 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            int x = 5;
            for (int i = 2; i < 7; i++)
            {
                x++;
            }
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
