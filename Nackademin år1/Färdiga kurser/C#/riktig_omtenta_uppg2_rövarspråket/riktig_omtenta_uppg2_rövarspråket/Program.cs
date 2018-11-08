using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg2_rövarspråket
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "sjörövare ohoj";
            string nyText = "";

            char[] bokstäver = text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (bokstäver[i] != 'a' && bokstäver[i] != 'e' && bokstäver[i] != 'i' && bokstäver[i] != 'o' &&
                    bokstäver[i] != 'u' && bokstäver[i] != 'y' && bokstäver[i] != 'å' && bokstäver[i] != 'ä' &&
                    bokstäver[i] != 'ö' && bokstäver[i] != ' ')
                {
                    string nyaBokstäver = bokstäver[i] + "o" + bokstäver[i];
                    nyText += nyaBokstäver;
                }
                else
                {
                    nyText += bokstäver[i];
                }
            }
            Console.WriteLine(nyText);
            Console.ReadLine();
        }
    }
}
