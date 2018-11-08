using System;
using System.Collections.Generic;
using System.Text;

namespace Hänga_gubbe
{
    public class Game
    {
        public string SecretWord { get; set; }
        public int NrOfGuesses { get; set; }
        public int NrOfIncorrectGuesses { get; set; }
        public int nrOfLettersInWord { get; set; }
        public string[] UsedLetters;
        public string[] CorrectLetters { get; set; }
        public string CurrentGuessedLetter { get; set; }
        public bool PlayerIsAlive { get; set; }
        public bool WordContainsGuessedLetter { get; set; }

        public void StartGame()
        {
            PrintWelcomeText();

            Player player = new Player();

            SecretWord = ChosingSecretWord();
            nrOfLettersInWord = GetNrOfLettersInWord(SecretWord);
            

            do
            {
                CurrentGuessedLetter = player.MakeGuess();
                WordContainsGuessedLetter = GetIfWordContainsGuessedLetter(CurrentGuessedLetter);

                if (WordContainsGuessedLetter == true)
                {

                }

            } while (player.PlayerIsAlive == true);
        }

        private void PrintWelcomeText()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("             HANG MAN             ");
            Console.WriteLine("**********************************");
        }

        private string ChosingSecretWord()
        {
            Console.WriteLine("Secret word: ");
            string secretWord = Console.ReadLine();

            return secretWord;
        }

        private int GetNrOfLettersInWord(string secretWord)
        {
            int nrOfLetters = secretWord.Length;

            return nrOfLetters;
        }

        private void InitialiseArray()
        {
            CorrectLetters = new string[nrOfLettersInWord];
        }

        private bool GetIfWordContainsGuessedLetter(string currentGuessedLetter)
        {
            bool result = false;

            foreach (var letter in SecretWord)
            {
                if (letter.ToString() == currentGuessedLetter)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        private void LetterIsIncorrect()
        {

        }

        private void GetIfPlayerIsAlive()
        {
            if (NrOfIncorrectGuesses == NrOfGuesses)
            {
                PlayerIsAlive = false;
            }

            PlayerIsAlive = true;
        }

        private void EndGame()
        {

        }
    }
}
