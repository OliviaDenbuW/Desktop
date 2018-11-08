using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Rekursivt_Fibonacci
{
    class Program
    {
        //EJ JAG SOM GJORT
        static void Main(string[] args)
        {
            Console.WriteLine("#7 i serien är: " + F(7));
            Console.ReadLine()
        }
        static int F(int sekvens)
        {
            if (sekvens <= 2)
                return 1;

            return F(sekvens - 1) + F(sekvens - 2);
        }
    }
}
