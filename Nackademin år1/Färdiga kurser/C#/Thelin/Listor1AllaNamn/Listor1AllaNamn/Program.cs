using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listor1AllaNamn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 12.1 - Alla namn - Del 1
            string[] names = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Name {0}: ", i+1);
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }
    }
}
