using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg2_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchValue = "a";
            string frase = "Jag har en mening som jag skall göra en sökning i";

            string[] words = frase.Split(' ');
            int counter = 0;

            foreach (var word in words)
            {
                if (word.Contains('a'))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

            Console.ReadLine();
        }
    }
}
