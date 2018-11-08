using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Metoder_UpprepaText
{
    class Program
    {
        static void Main(string[] args)
        {
            UpprepaText("Olivia", 7, "Maria", 8);

            Console.ReadLine();
        }

        static void UpprepaText (string text1, int antalGångerUpprepning1, string text2, int antalggr2)
        {
            for (int i = 0; i < antalGångerUpprepning1; i++)
            {
                Console.WriteLine(text1);
            }

            for (int i = 0; i < antalggr2; i++)
            {
                Console.WriteLine(text2);
            }
        }
    }

}
