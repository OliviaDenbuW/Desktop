using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3VäderStationen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of meassures you have made: ");
            int nrOfMessures = Int32.Parse(Console.ReadLine());
            decimal averageTemp = 0;

            decimal[] temperatures = new decimal[nrOfMessures];

            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write("Day {0}: ", i+1);
                temperatures[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine("Temp {0}: {1}", i+1, temperatures[i]);
                averageTemp += temperatures[i];
            }

            Console.WriteLine();
            Console.WriteLine("The average temperature is: {0}", averageTemp);
            Console.ReadLine();
        }
    }
}
