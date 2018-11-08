using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Loops_Mosh_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should
            //calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.Write("Nummer att fakultera: ");
            int nummer = int.Parse(Console.ReadLine());
            int produkt = 1;

            for (int i = 1; i <= 5; i++)
            {
                produkt *= i;
            }
            Console.WriteLine("{0}! = {1}", nummer, produkt);


            //VARFÖÖÖÖÖÖÖÖÖÖÖÖR FEL??????????????

            //Console.Write("Nummer att fakultera: ");
            //int nummer = int.Parse(Console.ReadLine());
            //int produkt = 1;

            //for (int i = nummer; i > 0; i--)
            //{
            //    produkt *= nummer;
            //}

            //Console.WriteLine("{0}! = {1}", nummer, produkt);
            Console.ReadLine();
        }
    }
}
