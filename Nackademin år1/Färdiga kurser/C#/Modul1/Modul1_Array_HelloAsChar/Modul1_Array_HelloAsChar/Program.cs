using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Array_HelloAsChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //En text kan göras om till en charArray
            string text = "Hello";
            char[] textAsArray = { 'H', 'e', 'l', 'l', 'o' };

            
            Console.WriteLine("{0} har {1} bokstäver", text, textAsArray.Length);


            //// String kan behandlas som en array och char (men inte tvärtom)
            //string hej = "Hello";
            //char[] hejchararray = { 'H', 'e', 'l', 'l', 'o' };

            //Console.WriteLine($"hej Length:{hej.Length} hej[0]:{hej[0]}");
            Console.ReadLine();
        }
    }
}
