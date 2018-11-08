using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_Studentportalen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*****************************************
             UPPG 11

            /*****************************************
             UPPG 10

            /*****************************************
             UPPG 9

            /*****************************************
             UPPG 8

            /*****************************************
             UPPG 7

            /*****************************************
             UPPG 6

            /*****************************************
             UPPG 5
            Console.Write("Type your age: ");
            int age = int.Parse(Console.ReadLine());
            bool isOverEighteen = CheckingIfPersonIsOverEighteen(age);

            if (isOverEighteen == true)
            {
                Console.WriteLine("Over 18");
            }
            else
            {
                Console.WriteLine("Not over 18");
            }
            

            /*****************************************
             UPPG 4*/



            /*****************************************
             UPPG 3
            string frase = AddingStrings("hej", "då");
            Console.WriteLine(frase);

            /*****************************************
             UPPG 2
            Console.Write("Type a decimal number between 0-1: ");
            double decimalNumber = double.Parse(Console.ReadLine());
            double nrInPercentage = ToPercentage(decimalNumber);

            Console.WriteLine("{0} = {1}%", decimalNumber, nrInPercentage);

            /******************************************
             UPPG 1
             PrintMessage();
             ******************************************/
            Console.ReadLine();
        }

        static bool CheckingIfPersonIsOverEighteen(int age)
        {
            if (age > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string AddingStrings(string firstWord, string secondWord)
        {
            string frase = firstWord + " " + secondWord;
            return frase;
        }

        //UPPG 2
        static double ToPercentage(double decimalNumber)
        {
            double nrInPercentage = decimalNumber * 100;
            return nrInPercentage;
        }

        //UPPG 1
        static void PrintMessage()
        {
            Console.WriteLine("Hello world");
        }
    }
}
