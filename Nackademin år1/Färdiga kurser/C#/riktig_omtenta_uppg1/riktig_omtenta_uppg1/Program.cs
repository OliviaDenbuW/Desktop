using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jämtDelbaraMedTre = new int[100];

            Random random = new Random();
            int nr = 0;
            int sum = 0;
            double medelvärde = 0;

            for (int räknare = 0; räknare < 10; räknare++)
            { 
                nr = random.Next(int.MinValue, int.MaxValue);
                if (nr % 3 == 0)
                {
                    sum += nr;
                }
                Console.WriteLine(nr);
            }

            medelvärde = (double)sum / 100;

            Console.WriteLine("Medelvärde : {0}", medelvärde);
            Console.ReadLine();
        }
    }
}
