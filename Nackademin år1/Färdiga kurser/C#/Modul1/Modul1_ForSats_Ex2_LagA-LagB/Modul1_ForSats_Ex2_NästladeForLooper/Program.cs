using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_ForSats_Ex2_NästladeForLooper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Det finns x-antal lag
            //Alla lag möter varje lag en gång

            Console.Write("Antal lag: ");
            int antalLag = int.Parse(Console.ReadLine());

            for (int lagA = 1; lagA < antalLag; lagA++)
            {
                for (int lagB = 2; lagB <= antalLag; lagB++)
                {
                    Console.WriteLine("Lag{0} - Lag{1}", lagA, lagB);
                }
            }
            Console.ReadLine();







            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i + 1; j <= 5; j++)
            //    {
            //        Console.WriteLine("Lag " + i + " - Lag " + j);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
