using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_ParamArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 4, 4, 5, 9 };
            ParamArray(number);
            Console.ReadLine();
        }

        //Metod som behandlar array
        public static void ParamArray(params int[] numbers)
        {
            int lengthOfArray = numbers.Length;
            Console.WriteLine("Number of params in array is {0}", lengthOfArray);
            Console.WriteLine();
            foreach (var nr in numbers)
            {
                Console.WriteLine(nr);
            }
        }
    }
}
