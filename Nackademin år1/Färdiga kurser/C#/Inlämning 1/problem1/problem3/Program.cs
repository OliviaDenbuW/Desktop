using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game");

            string answerPlayAgain;
            do
            {
                GuessNumber();

                do
                {
                    Console.WriteLine("Do you want to play again? (yes/no)");
                    answerPlayAgain = Console.ReadLine();

                } while (answerPlayAgain != "yes" && answerPlayAgain != "no");

            } while (answerPlayAgain == "yes");

            Console.WriteLine("Press ENTER to exit");

            Console.ReadKey();
        }

        static void GuessNumber()
        {
            Random generator = new Random();

            bool guessIsNr, isRightGuess;
            string input;
            int guess, rightNr, nrOfGuesses;

            isRightGuess = false;
            nrOfGuesses = 1;

            rightNr = generator.Next(1, 101);

            Console.WriteLine("What number am I thinking about? (1-100)");
            Console.WriteLine();


            while (!isRightGuess)
            {
                Console.Write("Guess {0}: ", nrOfGuesses);
                input = Console.ReadLine();

                guessIsNr = int.TryParse(input, out guess);

                if (guessIsNr == true)
                {
                    if ((guess < rightNr) || (guess > rightNr))
                    {
                        nrOfGuesses++;

                        if (guess < rightNr)
                        {
                            Console.WriteLine("Wrong! The number is bigger");
                            Console.WriteLine();
                        }
                        else if (guess > rightNr)
                        {
                            Console.WriteLine("Wrong! The number is smaller");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Correct! You made it in {0} guesses", nrOfGuesses);
                        Console.WriteLine();

                        isRightGuess = true; //Avslutar loopen
                    }
                }
                /*else if ((guess < 1) ||  (guess > 100))
                {
                    Console.WriteLine("You did not enter a number between 1-100. Please try again");
                    Console.WriteLine();
                }*/
                else
                {
                    Console.WriteLine("Incorrect input. Must be written with numbers. Please try again");
                    Console.WriteLine();
                }
            }


        }

        //static void QuestionPlayAgain()
        //{
        //    //string answerPlayAgain;
        //    //do
        //{
        //    Console.WriteLine("Do you want to play again? (yes/no)");
        //    answerPlayAgain = Console.ReadLine();


        //} while (answerPlayAgain != "yes" && answerPlayAgain != "no");

        //string answerPlayAgain = "";

        //Console.Write("Would you like to play again (Yes/No)? ");
        //answerPlayAgain = Console.ReadLine();

        //if (answerPlayAgain == "Yes")
        //{
        //    Console.WriteLine();
        //    GuessNumber();
        //}
        //else if (answerPlayAgain == "No")
        //{
        //    Console.WriteLine();
        //    //    Console.WriteLine("Thank you for playing!");
        //    //}
        //}
    }
}
