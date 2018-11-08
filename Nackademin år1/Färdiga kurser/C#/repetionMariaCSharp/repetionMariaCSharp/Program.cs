using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetionMariaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jämtDelbaraMedTre = new int[10];

            Random random = new Random();
            int nr = 0;
            int sum = 0;


            for (int räknare = 0; räknare < 10; räknare++)
            {
                nr = random.Next(1,30);
                if (nr % 3 == 0)
                {
                    sum += nr;
                    Console.WriteLine(nr + "skriver ut tal delbart med 3");
                }

                Console.WriteLine(nr + "skriver ut alla tal i loopen");
            }

            Console.ReadLine();
        }
    }
}
