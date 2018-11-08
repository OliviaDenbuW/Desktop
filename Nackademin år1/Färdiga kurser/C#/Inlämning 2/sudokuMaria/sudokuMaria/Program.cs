using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokuMaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Sudoku game = new Sudoku("003020600900305001001806400"+"008102900700000008006708200"+"002609500800203009005010300");
            //string SudokuInput = "12338268862";
            //int[,] Sudokubräde = new int[9, 9];
            //int counter = 0;

            //for (int row = 0; row < 9; row++)
            //{
            //    for (int col = 0; col < 9; col++)
            //    {
            //        Sudokubräde[row, col] = SudokuInput[counter];
            //        counter++;
            //    }
            //}
        }
    }
}
