using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pangNumber = 3;
            const int boomNumber = 5;

            for (int i = 1; i <= 100; i++)
            {
                if((i % pangNumber == 0) || (i % boomNumber == 0))
                {
                        if ((i % pangNumber == 0) && (i % boomNumber == 0))
                        {
                            Console.WriteLine("PANG BOOM");
                        }
                        else if (i % pangNumber == 0)
                        {
                            Console.WriteLine("PANG");
                        }
                        else if (i % boomNumber == 0)
                        {
                            Console.WriteLine("BOOM");
                        }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
