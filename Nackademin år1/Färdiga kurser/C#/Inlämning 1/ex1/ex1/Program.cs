using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                PangBoom(i);
            }

            Console.ReadLine();

        }

        static void PangBoom(int i)
        {
            if ((i % 3 == 0) || (i % 5 == 0))
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("PANG BOOM");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("PANG");
                }
                else
                {
                    Console.WriteLine("BOOM");
                }
            }

            Console.WriteLine(i + 1);
        }
    }
}
