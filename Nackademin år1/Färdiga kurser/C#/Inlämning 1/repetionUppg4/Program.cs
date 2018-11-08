using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetionUppg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text to be converted: ");
            string text = Console.ReadLine();

            Console.Write("Key number: ");
            int keyNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Ceasar(text, keyNumber);
            

            Console.ReadLine();

        }

        static void Ceasar(string text, int keyNumber)
        {
            char[] textArray = text.ToCharArray();
            
        }
       
    }
}
