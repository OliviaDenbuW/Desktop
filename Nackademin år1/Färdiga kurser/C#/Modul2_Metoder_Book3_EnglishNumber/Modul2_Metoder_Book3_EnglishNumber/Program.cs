using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Metoder_Book3_EnglishNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());

            LastNumberAsLetter(number);
            Console.ReadLine();
        }

        static string LastNumberAsLetter(int number)
        {
            int remainder = number % 10;

            switch(remainder)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "one";
                    break;
                case 3:
                    return "one";
                    break;
                case 4:
                    return "one";
                    break;
                case 5:
                    return "one";
                    break;
                case 6:
                    return "one";
                    break;
                case 7:
                    return "one";
                    break;
                case 8:
                    return "one";
                    break;
                case 9:
                    return "one";
                    break;
            }
        }
    }
}
