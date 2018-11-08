using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetionUppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice generator");
            Console.WriteLine();
            int numberOfRounds = CollectingDataForGame("How many rounds would you like to play? ");
            int numberOfDices = CollectingDataForGame("How many dices would you like to use? ");
            int numberOfSides = CollectingDataForGame("How many sides do the dices have? ");
            Console.WriteLine();

            //Totala summan för att kunna beräkna medelvärdet av alla omgångar
            int totSum = 0;

            //Man måste skapa tärningsobjektet/generatonrn utanför alla loopar. Annars får man inte nya tärningsvärden
            Random theDice = new Random();

            //Den yttre loopen håller endast koll på att räkna upp ommgångarna. Beräkningarna sker i den inre
            for (int round = 1; round <= numberOfRounds; round++)
            {
                Console.Write("Omgång {0}: ", round);

                //Måste skapas utanför loopen så att den är nollställd till kommande omgång
                int sumPerRound = 0;
                for (int dice = 1; dice <= numberOfDices; dice++)
                {
                    int valueForEachDice = theDice.Next(1, 7);
                    sumPerRound += valueForEachDice; //Addar på det nya tärningsvärdet till summan per omgång

                    Console.Write("{0} ", valueForEachDice);
                }

                Console.Write("= {0}", sumPerRound);
                totSum += sumPerRound;

                Console.WriteLine();
            }

            int averageAmountPerRound = totSum / numberOfRounds;

            Console.WriteLine();
            Console.WriteLine("Average amount per round: {0}", averageAmountPerRound);

            //bool playedAllRounds = false;

            //do
            //{
            //    int currentRound = 1;
            //    Console.Write("Omgång {0}: ", currentRound);
            //    currentRound++;

            //    playedAllRounds = true;

            //} while (!playedAllRounds);

            Console.ReadKey();
        }

        static int CollectingDataForGame(string question)
        {
            Console.Write(question);
            int input = Int32.Parse(Console.ReadLine());

            return input;
        }
    }
}
