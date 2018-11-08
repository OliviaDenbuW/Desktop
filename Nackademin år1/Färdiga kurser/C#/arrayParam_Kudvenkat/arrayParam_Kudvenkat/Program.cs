using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayParam_Kudvenkat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            //ParamsMethod();
            //ParamsMethod(numbers);
            ParamsMethod(1, 2, 3, 4, 5, 6);
            Console.ReadLine();
        }

        public static void ParamsMethod(int x, params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);

            foreach (var nr in Numbers)
            {
                Console.WriteLine(nr);
            }
        }
    }
}
