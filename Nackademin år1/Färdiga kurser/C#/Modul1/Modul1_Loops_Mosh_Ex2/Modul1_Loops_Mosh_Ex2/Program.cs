using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Loops_Mosh_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and continuously ask the user to enter a
            //number or "ok" to exit. Calculate the sum of all
            //the previously entered numbers and display it on the console.

            double sum = 0;

            while (true)
            {
                Console.Write("Skriv ett nummer: (eller 'ok' för att avsluta) ");
                string input = Console.ReadLine();

                if (input == "ok")
                {
                    break;
                }

                sum += double.Parse(input);
            }

            Console.WriteLine("Summan av samtliga tal: {0}", sum);
            //bool användarenVillFortsätta = true;
            //double sum = 0;

            //do
            //{
            //    Console.Write("Number: ");
            //    double nummer = double.Parse(Console.ReadLine());

            //    sum += nummer;

            //    Console.Write("Vill du fortsätta? (ja/nej) ");
            //    string svar = Console.ReadLine();

            //    if (svar == "nej".ToLower())
            //    {
            //        användarenVillFortsätta = false;
            //    }
            //} while (användarenVillFortsätta);

            //Console.WriteLine();
            //Console.WriteLine("Summan av samtliga inmatade tal blev: {0}", sum);
            //Console.WriteLine("Tryck enter för att avsluta");
            Console.ReadLine();
        }
    }
}
