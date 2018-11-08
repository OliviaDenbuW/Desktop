using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Stränghantering_ÄndraEnstakaTeckenISträng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är en liten kakbit");
            string text = Console.ReadLine();
            char[] array = text.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 't')
                {
                    array[i] = 'R';
                }
            }

            foreach (var bokstav in array)
            {
                Console.Write(bokstav);
            }
            Console.ReadLine();
        }
    }
}
