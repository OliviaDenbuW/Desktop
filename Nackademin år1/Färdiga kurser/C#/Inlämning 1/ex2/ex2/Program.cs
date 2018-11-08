using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds, dizes, sides;
                        
            Console.Write("Nr of rounds: ");
            rounds = Int32.Parse(Console.ReadLine());

            Console.Write("Nr of dizes: ");
            dizes = Int32.Parse(Console.ReadLine());

            Console.Write("Nr of sides on the dizes: ");
            sides = Int32.Parse(Console.ReadLine());

            Random randomNrOnDize = new Random();
            int value = randomNrOnDize.Next(1, sides);

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine(value);
            }

        
            Console.ReadKey();
        }
    }
}
