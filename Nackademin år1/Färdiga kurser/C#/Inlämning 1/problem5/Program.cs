using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrRemainingGuesses = 6;
            bool wordFound = false;
            char[] guessedLetters = new char[29];
            int guessedLettersIndex = 0;

            Console.WriteLine("Den som ska spela måste titta bort nu!");
            string secretWord = ReadString("Skriv in ett ord: ").ToUpper();

            Console.Clear();

            do
            {
                PrintingCatchedLetters(secretWord, guessedLetters);
                PrintMisses(secretWord, guessedLetters);

                string guessedWord = ReadString("Gissa en bokstav eller ordet? ").ToUpper();
                Console.WriteLine();

                if (guessedWord.Length == 1)            //Omgissningen är EN bokstav
                {
                    char guess = guessedWord[0];
                    if (guessedLetters.Contains(guess))
                    {
                        Console.Write("Du har redan försökt med {0}!", guess);
                        Console.WriteLine("Du har {0} gissningar kvar. ", nrRemainingGuesses);
                    }
                    else if (secretWord.Contains(guess))
                    {
                        guessedLetters[guessedLettersIndex] = guess;
                        guessedLettersIndex++;

                        wordFound = true;
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            if (!guessedLetters.Contains(secretWord[i]))
                            {
                                wordFound = false;
                            }
                        }

                        Console.WriteLine("Rätt! ");
                        Console.WriteLine("Du har {0} gissningar kvar", nrRemainingGuesses);
                    }
                    else                
                    {
                        guessedLetters[guessedLettersIndex] = guess;
                        guessedLettersIndex++;
                        nrRemainingGuesses--;
                        Console.Write("Fel! ");
                        Console.WriteLine("Du har {0} gissningar kvar", nrRemainingGuesses);
                    }
                }
                else                //Om gissningen är ett ord
                {
                    if (guessedWord == secretWord)
                    {
                        wordFound = true;
                    }
                    else
                    {
                        nrRemainingGuesses--;
                        Console.WriteLine("Fel ord! Du har {0} gissningar kvar", nrRemainingGuesses);
                    }
                }


            } while (wordFound == false && nrRemainingGuesses > 0);

            if (wordFound == true)
            {
                HappyEnd(secretWord);
            }
            else
            {
                HangEnd(secretWord);
            }

            Console.ReadKey(true);
        }

        private static void HangEnd(string secretWord)
        {
            Console.WriteLine();
            Console.WriteLine("Du har misslyckats med att gissa ordet: {0}", secretWord);
            Console.WriteLine("Nu blir du hängd...........");
            Console.WriteLine();
        }

        private static void HappyEnd(string secretWord)
        {
            Console.WriteLine();
            Console.WriteLine("Du har gissat rätt ord: {0}", secretWord);
            Console.WriteLine("Grattis!!!");
            Console.WriteLine();
        }

        //Metod som skriver ut Ord: _ _ A _ A_ _ L
        private static void PrintingCatchedLetters(string secretWord, char[] guessedLetters) 
        {
            Console.Write("Ord:");
            for (int i = 0; i < secretWord.Length; i++)
            {
                Console.Write(" ");
                if (guessedLetters.Contains(secretWord[i]))
                {
                    Console.Write(secretWord[i]);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();
        }

        private static void PrintMisses(string secretWord, char[] guessedLetters)
        {
            Console.Write("Missar: ");
            foreach (var letter in guessedLetters)
            {
                if (!secretWord.Contains(letter))
                {
                    Console.Write(" " + letter);
                }

            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

    }
}  

