using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "sjörövare ohoj";
            char[] vokaler = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };

            char[] separeradeBokstäver = text.ToCharArray();
            string nyText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (separeradeBokstäver[i] != 'a' || separeradeBokstäver[i] != 'e' || separeradeBokstäver[i] != 'i' ||
                    separeradeBokstäver[i] != 'o' || separeradeBokstäver[i] != 'u' || separeradeBokstäver[i] != 'y' ||
                        separeradeBokstäver[i] != 'å' || separeradeBokstäver[i] != 'ä' ||
                        separeradeBokstäver[i] != 'ö' || separeradeBokstäver[0] != ' ')
                {
                    string nyaBokstäver = separeradeBokstäver[i] + "o" + separeradeBokstäver[i];
                    nyText += nyaBokstäver;
                }
                else
                {
                    nyText += separeradeBokstäver[i];
                }
            }

            Console.WriteLine(nyText);
            Console.WriteLine("sosjojörorövovarore ohohojoj");
            Console.ReadLine();
        }
    }
}
