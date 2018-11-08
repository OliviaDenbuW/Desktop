using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoParametrar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;

            int c = Summa1(5, 4);
            // int d = Summa2( 5,  4); Kompilerar inte!
            // int d = Summa2(ref 5, ref 4); Kompilerar inte!
            a = Summa2(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static int Summa1(int x, int a)
        {
            x++;
            int b = x + a;
            return b;
        }

        static int Summa2(ref int x, ref int a)
        {
            x++;
            int b = x + a;
            return b;
        }
    }
}
