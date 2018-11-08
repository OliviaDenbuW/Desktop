using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_ArrayList_Mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listNames = new List<string>();

            while (true)
            {
                Console.Write("Name: (or enter to exit program) ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                listNames.Add(input);
            }

            int antalNamn = listNames.Count();
            PrintingLine(listNames, antalNamn);
            Console.ReadLine();
        } 

        public static void PrintingLine(List<string> listNames, int antalNamn)
        {
            if (antalNamn > 2)
            {
                Console.WriteLine("[0], [1] and [2] others like your post",listNames[0], listNames[1], antalNamn-2 );
            }
            else if ()
            {

            }
            e
        }
    }
}
