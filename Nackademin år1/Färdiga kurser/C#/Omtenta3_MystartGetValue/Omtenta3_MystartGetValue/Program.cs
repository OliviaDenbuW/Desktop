using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta3_MystartGetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStartMethod();
            Console.ReadLine();
        }

        public static double GetValue(double nr1, double nr2)
        {
            if (nr1 > nr2)
            {
                double prod = nr1 * nr2;
                return prod;
            }
            else
            {
                return -1;
            }
        }

        public static void MyStartMethod()
        {
            double returnValue = GetValue(19, 7);
            Console.WriteLine(returnValue);
        }
    }
}
