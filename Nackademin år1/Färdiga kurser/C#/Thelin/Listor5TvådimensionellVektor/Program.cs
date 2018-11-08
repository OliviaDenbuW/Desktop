using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listor5TvådimensionellVektor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gameBoard = new int[4, 4];

            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                Console.WriteLine("-------------------------");
                Console.Write("| ");
            }
            
            Console.ReadLine();
        }
    }
}
