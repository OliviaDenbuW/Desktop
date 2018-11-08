using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ConditionalsMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr1: ");
            string input1 = Console.ReadLine();
            int nr1 = Convert.ToInt32(input1);

            Console.Write("Nr2: ");
            string input2 = Console.ReadLine();
            int nr2 = Convert.ToInt32(input2);

            int max = (nr1 > nr2) ? nr1 : nr2;

            Console.WriteLine("Max nr: {0}", max);
            Console.ReadLine();
        }
    }
}
