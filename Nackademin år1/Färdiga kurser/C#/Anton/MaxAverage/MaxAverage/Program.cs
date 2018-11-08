using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double c = 7;

            Console.WriteLine(Numbers(a, b, c));
            Console.ReadLine();
        }

        public static (int, double) Numbers(int a, int b, int c)
        {
            int large = Math.Max(a, b);
            large = Math.Max(large, c);

            double average = (a + b + c) / 3;
            return (large, average);
        }
    }
}
