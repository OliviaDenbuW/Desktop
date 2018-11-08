using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Loops_Mosh_Ex4_RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number. If the user
            //guesses the number, display “You won"; otherwise, display
            //“You lost". (To make sure the program is behaving correctly
            //you can display the secret number on the console first.)

            int random = new Random().Next(1, 10);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Gissa talet: ");
                int gissning = int.Parse(Console.ReadLine());

                if (gissning == random)
                {
                    Console.WriteLine("Du vann!");
                    break;
                }
                else if ((gissning != random) && (i == 4))
                {
                    Console.WriteLine("Du förlorade!");
                    Console.WriteLine("Det hemliga talet var {0}", random);
                }
            }

            Console.ReadLine();
        }
    }
}
