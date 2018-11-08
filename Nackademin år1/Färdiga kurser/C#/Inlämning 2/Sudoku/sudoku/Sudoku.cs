using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku
{
    public class Sudoku
    {
        //PROPERTIES
        public int Numbers { get; set; } //1-9
        public int[] Row { get; set; }
        public int[] Column { get; set; }
        public int[, ,] Cell { get; set; }
        public int[,] Index { get; set; }
        public int Sum { get; set; }

        //METOD som loopar igenom en box
        

        //Metod som skapar brädet
        public void CreatingPlayBoard()
        {
            int[,] board = { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9 } };
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine(board[i, 0] + " " + board[i, 1] + " " + board[i, 2]);
            }
        }


        //Yttre loop går igenom rader
        public void LoopingThroughBox()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {

                }
            }
        }
        

        


    }
}
