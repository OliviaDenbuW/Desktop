using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Metoder_Book4_FindSameNrsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[] { 1, 2, 4, 4, 2, 3, 7, 8, 4, 9, 0 };
            int searchedNumber = 4;
            int countedTimes = FindingSameNumber(arrayNumbers, searchedNumber);
            Console.WriteLine(countedTimes);

            Console.ReadLine();
        }

        static int FindingSameNumber(int[] arrayNumbers, int searchedNumber)
        {
            int counter = 0;

            foreach (var number in arrayNumbers)
            {
                if (number == searchedNumber)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
