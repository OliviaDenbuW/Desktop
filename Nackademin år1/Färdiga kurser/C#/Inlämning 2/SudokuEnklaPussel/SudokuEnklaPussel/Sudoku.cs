using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuEnklaPussel
{
    public class Sudoku
    {
        private int[,] sudokuArray = new int[9, 9];
        private List<int> numbers = new List<int>(); //Skapa i knstruktorn??????????????

        ///<summary>
        ///Konstruktor för spelet
        ///* Tar in siffrorna från objektets inparameter i main
        ///* Metoden CreateBoard anropas - Siffrorna placeras ut
        ///</summary>
        ///<param name = "inputNumbers">Sudokuspelet i strängformat</param>
        public Sudoku(string inputNumbers)
        {
            CreateBoard(inputNumbers);
        }

        /// <summary>
        /// Skapar sudokumatrisen
        /// </summary>
        /// <param name="inputNumbers">Det råa formaten i strängformat - Siffrorna i strängar så vi kan hanter dem</param>
        private void CreateBoard(string inputNumbers)
        {
            int counter = 0;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    //Omvandlar vad - Explicit eller Implicit - KOLLA UPP SKILLNAD
                    sudokuArray[row, col] = (int)char.GetNumericValue(inputNumbers[counter]);
                    counter++;
                }
            }
        }

        private void AddNumbersToList()
        {
            numbers.Clear(); //Varje gång vi på nytt anropar metoden måste vi cleara siffrorna som ev kvarstod från föregående cell
            numbers.AddRange(Enumerable.Range(1, 9));
        }

        ///<summary>
        ///Löser hela sudokut
        /// </summary>
        public void Solve()
        {
            bool test = true;
            bool sudokuIsSolved = false;

            do
            {   
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        AddNumbersToList();
                        if (CellContainsZero(row, col))
                        {
                            test = true;
                            SolvedNumbersCurrentRow(row, col);
                            SolvedNumbersCurrentCol(row, col);

                            SolvedNumbersCurrentBox(row, col);
                            if (numbers.Count == 1)
                            {
                                sudokuArray[row, col] = numbers[0];
                            }
                        }
                    }
                }
            } while (!sudokuIsSolved);
        }

        public bool CellContainsZero(int row, int col)
        {            
            if(sudokuArray[row, col] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SolvedNumbersCurrentRow(int rowFixed, int colFixed)
        {
            for (int col = 0; col < 9; col++)
            {
                if (numbers.Contains(sudokuArray[rowFixed, col]))
                {
                    numbers.Remove(sudokuArray[rowFixed, col]);
                }
            }
        }

        public void SolvedNumbersCurrentCol(int rowFixed, int colFixed)
        {
            for (int row = 0; row < 9; row++)
            {
                if (numbers.Contains(sudokuArray[row, colFixed]))
                {
                    numbers.Remove(sudokuArray[row, colFixed]);
                }
            }
        }

        public void SolvedNumbersCurrentBox(int rowCheck, int colCheck)
        {
            bool minAndMaxValueFoundRow = false;
            bool minAndMaxValueFoundCol = false;
            bool collectedAllSolvedNumbers = false;
            int rowMin = 0;
            int rowMax = 0;
            int colMin = 0;
            int colMax = 0;

            do
            {
                while ((rowCheck % 3) != 0)
                {
                    rowCheck--;
                    rowMin = rowCheck;
                }

                while (((rowCheck + 1) % 3) != 0)
                {
                    rowCheck++;
                    rowMax = rowCheck;
                    minAndMaxValueFoundRow = true;
                }
            } while (!minAndMaxValueFoundRow);

            do
            {
                while ((colCheck % 3) != 0)
                {
                    colCheck--;
                    colMin = colCheck;
                }

                while (((colCheck + 1) % 3) != 0)
                {
                    colCheck++;
                    colMax = colCheck;
                    minAndMaxValueFoundCol = true;
                }
            } while (!minAndMaxValueFoundCol);

            do
            {
                for (int x = rowMin; x < (rowMax + 1); x++)
                {
                    for (int y = colMin; y < (colMax + 1); y++)
                    {
                        if (numbers.Contains(sudokuArray[x, y]))
                        {
                            numbers.Remove(sudokuArray[x, y]);
                        }
                    }
                }
            } while (!collectedAllSolvedNumbers);
        }


        ///<summary>
        ///Kollar om nuvarande spelet är löst (Finns det några nollor kvar i programmet?)
        /// </summary>
        public bool IsGameSolved
        {
            get
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        //Om det är en nolla så är ju inte problemet löst --> Returnera FALSE på IsGameSolved
                        if (sudokuArray[row, col] == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        //PROPERTY: Kan ha (Get OCH Set) / (Get ELLER Set (Bara Get: READonly - Bara Set: WRITEonly)
        //EX.

        /***********************************
        private int month = 7;  // Backing store

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if ((value > 0) && (value < 13))
                {
                    month = value;
                }
            }
        }****************************************/



        /// <summary>
        /// Formaterar brädan som en sträng
        /// </summary>
        ///<returns></returns>
        private string GetFormatedBoard()
        {
            //Det är snyggare kod att avnända StringBuilder än att använda ConsoleKlassen (när vi är utanför Program.cs)
            StringBuilder sb = new StringBuilder();
            int counterCell = 0;

            foreach (var value in sudokuArray)
            {
                //Delar efter tre rader
                if((counterCell % 27) == 0)
                {
                    sb.AppendLine(string.Concat(Enumerable.Repeat("-", 22)));
                }
                else if ((counterCell % 3) == 0)
                {
                    sb.Append("|");
                }

                sb.Append($"{value} ");
                counterCell++;
                //????????????????????????????????????????????????????????

                else if ((counterCell % 9) == 0)
                {
                    sb.Append("|");
                    sb.AppendLine();
                }
                else if(sudokuArray.Length == counterCell)
                {
                    sb.AppendLine(string.Concat(Enumerable.Repeat("-", 22)));
                }
            }
            return sb.ToString();
        }

        public string BoardAsText
        {
            get
            {
                return GetFormatedBoard();
            }
        }

    }
}
