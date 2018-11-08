using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchValue = "a";
            string frase = "Jag har en mening som jag skall göra en sökning i";
            int counter = 0;

            string[] words = frase.Split(' ');

            foreach (var word in words)
            {
                if (word.Contains(searchValue))
                {
                    counter++;
                }
            }
            Console.WriteLine("Contains {0} words with {1}", counter, searchValue);
            Console.ReadLine();
        }
    }
}
