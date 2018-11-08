using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetionUppg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number am I thinking about (1-100)? ");

            //Skapar randomnumret (det korrekta talet)
            Random generator = new Random();
            int secretNumber = generator.Next(1, 101);

            bool correctGuess = false;
            int numberOfGuesses = 1;

            do
            {
                Console.WriteLine();
                Console.Write("Guess {0}: ", numberOfGuesses);
                int guess = Int32.Parse(Console.ReadLine());

                if (guess != secretNumber)
                {
                    numberOfGuesses++;
                    

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Wrong! The number is bigger");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Wrong! The number is smaller");
                    }
                }
               else
                {
                    correctGuess = true;
                }

            } while (correctGuess == false);

            Console.WriteLine();
            Console.WriteLine("Correct! The secret number was {0}", secretNumber);
            Console.WriteLine("You made it in {0} guesses", numberOfGuesses);

            Console.ReadLine();
        }
    }
}
