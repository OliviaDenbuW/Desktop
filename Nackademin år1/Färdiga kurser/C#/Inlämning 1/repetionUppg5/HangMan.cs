using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetionUppg5
{
    public class HangMan
    {
        int remainingGuesses = 6;
        bool wordFound = false;
        bool[] guessedLetters = new bool[26];

        public void PlayGame()
        {
            Console.WriteLine("The person who is going to play has got to look away now");
            Console.WriteLine();
            Console.WriteLine("                         ...");
            Console.WriteLine();
            string secretWord = ReadString("Chose secret word: ");
            Console.Clear();
            
            do
            {
                PrintingEmptyAndFilledLines(secretWord, guessedLetters);
                PrintMisses(secretWord, guessedLetters);

                string guessInput = ReadString("Guess a letter or the whole word: ");
                Console.WriteLine();

                if (guessInput.Length == 1) //Gissning är bokstav
                {
                    char guess = guessInput[0]; //Gör om den gissade bokstaven till en charArray med 1 plats
                    if (guessedLetters[(int)guess - 65])
                    {
                        Console.WriteLine("You have already guessed the letter {0}", guess);
                        Console.WriteLine("You have {0} guesses remaining", remainingGuesses); //Räknar inte som gissning
                    }
                    else if(secretWord.Contains(guess))
                    {
                        guessedLetters[(int)guess - 65] = true;
                    }
                }
                else
                {
                    if(guessInput == secretWord)
                    {
                        wordFound = true;
                        EndHappy(secretWord);
                    }
                    else
                    {
                        EndDead(secretWord);
                    }
                }


            } while ((!wordFound) && (remainingGuesses > 0));
        }

        public string ReadString(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine().ToUpper();

            return input;
        }

        public void PrintMisses(string secretWord, bool[] guessedLetters)
        {
            Console.WriteLine("Incorrect guesses: ");
            for (int i = 0; i < guessedLetters.Length; i++)
            {
                char letter = (char)(i + 65);
                if(guessedLetters[i] && !secretWord.Contains(letter))
                {
                    Console.Write(" {0}", letter);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //En bool array som säger om varje bokstav var TRUE eller FALSE gissning
        public void PrintingEmptyAndFilledLines(string secretWord, bool [] guessedLetters)
        {
            Console.Write("Word: ");

            //Printar ut antal sträck som ordet innehåller (sträcken fylls i när rätt bokstav hittats)
            for (int letter = 0; letter < secretWord.Length; letter++)
            {
                Console.Write(" ");
                if(guessedLetters[(int)secretWord[letter] - 65])
                {
                    Console.Write(secretWord[letter]);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();
        }

        public void EndHappy(string secretWord)
        {
            Console.WriteLine("CORRECT!!!! Pjuuuuuh.... you are not going to die");
            Console.WriteLine("The correct word was: {0}", secretWord);
        }

        public void EndDead(string secretWord)
        {            
            Console.WriteLine("Yu DEEEEEEEEEEEAD man!");
            Console.WriteLine("The correct word was: {0}", secretWord);
            Console.WriteLine();
        }
    }
}
