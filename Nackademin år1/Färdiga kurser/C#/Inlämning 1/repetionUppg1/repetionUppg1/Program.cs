using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetionUppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            //For-loop eftersom det är ett givet intervall
            for (int i = 1; i <= 100; i++)
            {
                PangBoom(i);
            }

            Console.ReadKey();
        }

        static void PangBoom(int i)
        {
            //Skapar konstanter
            const int PANG = 3;
            const int BOOM = 5;

            if (i%PANG == 0 || i%BOOM == 0)
            {
                if (i % PANG == 0 && i % BOOM == 0)
                {
                    Console.WriteLine("PANG BOOM");
                }
                else if (i % PANG == 0)
                {
                    Console.WriteLine("PANG");
                }
                else if (i % BOOM == 0)
                {
                    Console.WriteLine("BOOM");
                }
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

