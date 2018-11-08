using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spelAllmänbildning
{
    class Subjects
    {
        public void ShowSubjects()
        {
            do
            {
                Console.WriteLine("GAME SUBJECTS");
                Console.WriteLine("1) Black history");
                Console.WriteLine("2) Ethiopia");
                Console.WriteLine("3) Cities of the world");
                Console.WriteLine("4) Capitals in Africa");
                Console.WriteLine("5) Capitals in South America");
                Console.WriteLine("6) Capitals in Europe");
                Console.WriteLine("7) Swedish geography");
                Console.WriteLine("8) Save scores and exit game");
                Console.WriteLine();

                Console.Write("Enter number of choice: ");
                string inputOperationChoise = Console.ReadLine();

                Console.WriteLine();
                //PerformOperationOfChoice(inputOperationChoise);
            } while (/*wantsToContinuePlay == false*/);
        }

        public void PerformOperationOfChoice()
        {

        }
    }
}
