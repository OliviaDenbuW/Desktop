using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till tärningsstimulatorn!");
            int totalSum = 0;

            int nrRounds = ReadInt("Antal omgångar: ");
            int nrDices = ReadInt("Antal tärningar: ");
            int nrSides = ReadInt("Antal sidor: ");

            Random generator = new Random();

            //Loopar lika många ggr som det är Omgångar (1000)
            for (int round = 1; round <= nrRounds; round++)
            {
                Console.Write("Omgång {0}: ", round);

                int sumPerRound = 0;

                //Loopar lika många ggr som det finns tärningar
                for (int dice = 0; dice < nrDices; dice++)
                {
                    int value = generator.Next(1,7); //värdet för varje tärning
                    sumPerRound += value; //sumPerRound = sumPerRound + value;

                    Console.Write(value); //vädret för varje tärning
                    Console.Write(" ");
                }

                Console.Write("= ");
                Console.WriteLine(sumPerRound);
                totalSum += sumPerRound;
            }
            Console.WriteLine("Totala summan: {0}", totalSum);
            Console.WriteLine("Medelvärdet per omgång: {0}", (double)totalSum/(double)nrRounds);

            Console.ReadKey(true); 
            }

            private static int ReadInt(string question)
            {
            Console.Write(question);
            string input = Console.ReadLine();

            return int.Parse(input);
            }

            
        
    }
}
