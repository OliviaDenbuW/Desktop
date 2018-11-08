using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta1_RotenUr
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 265; i < 290; i++)
            {
                if (i%2 == 0)
                {
                    double roten = Math.Sqrt(i);
                    sum += roten;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
