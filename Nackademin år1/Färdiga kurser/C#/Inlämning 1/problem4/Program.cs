using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text;
                int key;

                Console.Write("Write text with CAPS: ");
                text = Console.ReadLine();

                text = text.ToUpper(); //Metod som konverterar till stora bokstäver
                text = text.Replace(" ", "");

                Console.Write("Chose a nr as key: ");
                key = int.Parse(Console.ReadLine());

                Console.WriteLine("Result: {0}", Caesar(text, key));
                Console.WriteLine();
            }
        }

        private static string Caesar(string text, int key) //Två inparametrar
        {
            char[] chiffer = text.ToCharArray(); //ABC (ChifferBeforeKonverting)

            for (int i = 0; i < chiffer.Length; i++) //chiffer.Length är antal tecken (men första bokstaven har index 0)
            {
                char newChar = chiffer[i]; //kommer in InnanKonvertering A
                newChar = (char)(newChar + (key % 26)); // konverteras D

                if (newChar > 'Z') //+90
                {
                    newChar = (char)(newChar - 26);
                }
                else if (newChar < 'A')//-65
                {
                    newChar = (char)(newChar + 26);
                }

                chiffer[i] = newChar;

            }
            return new string(chiffer);
        }
    }
}
