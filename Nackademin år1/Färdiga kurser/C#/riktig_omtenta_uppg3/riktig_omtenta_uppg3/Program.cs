using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tal1: ");
            double tal1 = double.Parse(Console.ReadLine());

            Console.Write("Tal2: ");
            double tal2 = double.Parse(Console.ReadLine());

            Console.Write("Tal3: ");
            double tal3 = double.Parse(Console.ReadLine());

            Console.Write("Tal4: ");
            double tal4 = double.Parse(Console.ReadLine());

            double min;
            double max;

            GetMinMax(tal1, tal2, tal3, tal4, out min, out max);

            Console.WriteLine("{0}, {1}, {2}, {3} ger min {4} och max {5}", tal1, tal2, tal3, tal4, min, max);
            Console.ReadLine();
        }

        public static void GetMinMax(double tal1, double tal2, double tal3, double tal4, out double min, out double max)
        {
            min = Math.Min(tal1, tal2);
            min = Math.Min(min, tal3);
            min = Math.Min(min, tal4);

            max = Math.Max(tal1, tal2);
            max = Math.Max(max, tal3);
            max = Math.Max(max, tal4);
        }
    }
}
