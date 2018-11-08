using System;
using System.Collections.Generic;
using System.Text;

namespace Hänga_gubbe
{
    public class Player
    {
        public bool PlayerIsAlive { get; set; }
        public string CurrentGuessedLetter { get; set; }

        public string MakeGuess()
        {
            Console.WriteLine("Guess a letter: ");
            CurrentGuessedLetter = Console.ReadLine();

            return CurrentGuessedLetter;
        }


    }
}
