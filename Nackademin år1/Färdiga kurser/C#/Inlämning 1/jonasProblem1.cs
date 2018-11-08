using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlUpp1Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pangNumber = 3;
            const int bomNumber = 5;

            for (int i = 1; i <= 100; i++)
            {
                if ((i%pangNumber == 0) || (i%bomNumber == 0)) {
                    if ((i%pangNumber == 0) && (i%bomNumber == 0))
                    {
                        Console.WriteLine("PangBom");
                    }
                    else if (i % pangNumber == 0)
                    {
                        Console.WriteLine("Pang");
                    }
                    else if (i % bomNumber == 0)
                    {
                        Console.WriteLine("Bom");
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey(true);
        }
    }
}
