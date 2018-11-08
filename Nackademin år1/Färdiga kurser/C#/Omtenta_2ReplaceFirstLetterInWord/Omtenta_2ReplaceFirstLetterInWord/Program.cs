using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta_2ReplaceFirstLetterInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Sex laxar i en laxask";

            string[] words = frase.Split(' ');

            foreach (var word in words)
            {
                string sub = word.Substring(0, 1);
                string changedLetter = sub.Replace(sub, "k");
                Console.WriteLine(changedLetter);
            }

            


            //var str = "Dont Hate Programming :D";
            //var firstLetters = new String(str.Split(' ').Select(x => x[0]).ToArray());
            //Console.WriteLine(firstLetters);

            Console.ReadLine();
        }
    }
}
