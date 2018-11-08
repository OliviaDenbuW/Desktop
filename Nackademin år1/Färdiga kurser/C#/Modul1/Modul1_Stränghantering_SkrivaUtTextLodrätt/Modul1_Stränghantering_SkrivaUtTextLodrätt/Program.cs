using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Stränghantering_SkrivaUtTextLodrätt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text: ");
            string inmatning = Console.ReadLine();
            int antalTeckenText = inmatning.Length;

            Console.WriteLine("Anatal tecken i din text är: {0}", antalTeckenText);
            Console.WriteLine();
            for (int i = 0; i < antalTeckenText; i++)
            {
                Console.WriteLine("Bokstav {0}: {1}", i+1, inmatning[i]);
            }
            Console.ReadLine();
        }
    }
}
