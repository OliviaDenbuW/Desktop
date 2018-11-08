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
                int shift;

                Console.WriteLine("Write text with CAPS: ");
                text = Console.ReadLine();

                text = text.ToUpper(); //Metod som konverterar till stora bokstäver
                text = text.Replace(" ", "");

                Console.WriteLine("Chose a nr as key");
                shift = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Result: {0}", Caesar(text, shift));
            }
        }

        private static string Caesar(string text, int shift) //Två inparametrar
        {
            char[] chiffer = text.ToCharArray();

            for (int i = 0; i < chiffer.Length; i++) //chiffer.Length är antal tecken (men första bokstaven har index 0)
            {
                char newChar = chiffer[i];
                newChar = (char)(newChar + (shift % 26));

                if (newChar > 'Z')
                {
                    newChar = (char)(newChar - 26);
                }
                else if (newChar < 'A')
                {
                    newChar = (char)(newChar + 26);
                }
                
                    chiffer[i] = newChar;
                
            }
            return new string(chiffer);
        }
    }
}
