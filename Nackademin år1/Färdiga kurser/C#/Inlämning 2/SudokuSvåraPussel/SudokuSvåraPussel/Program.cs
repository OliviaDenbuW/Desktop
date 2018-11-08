using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSvåraPussel
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new SudokuTough("003020600900305001001806400008102900700000008006708200002609500800203009005010300");
            game.Solve();
            if (game.IsGameSolved)
            {
                Console.WriteLine(game.BoardAsText);
            }
            else
            {
                Console.WriteLine("Kunde inte lösa spelet");
            }
            Console.ReadLine();
        }
    }
}
