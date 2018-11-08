using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg3_OutParam
{
    class Program
    {
        static void Main(string[] args)
        {
            double average;
            double max;

            MaxAndAverageValues(0.2, 20000, 0, out average, out max);

            Console.WriteLine("Average: {0}", average);
            Console.WriteLine("Max value: {0}", max);
            Console.ReadLine();
        }

        public static void MaxAndAverageValues(double nr1, double nr2, double nr3, out double average, out double max)
        {
            average = (nr1 + nr2 + nr3) / 3;
            max = Math.Max(nr1, nr2);
            max = Math.Max(max, nr3);
        }
    }
}
