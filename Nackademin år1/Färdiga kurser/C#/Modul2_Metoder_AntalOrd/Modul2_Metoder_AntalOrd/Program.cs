using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Metoder_AntalOrd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Du matade in {0}st ord", AntalOrd(text));
            Console.ReadLine();
        }

        public static int AntalOrd(string text)
        {
            string[] ord = text.Split(' ');
            int antalOrd = ord.Length;

            return antalOrd;
        }
    }
}
