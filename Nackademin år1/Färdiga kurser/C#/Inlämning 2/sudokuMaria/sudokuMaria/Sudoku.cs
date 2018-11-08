using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokuMaria
{
    public class Sudoku
    {
        //Skapar en KONSTRUKTOR
        public Sudoku(string sudokuInput)
        {

        }


        //Skapar metoden Solve() - Static - Gör att den är letbar


        public static void Solve()
        {
            List<int> siffror = new List<int>();
            siffror.Add(1);
            siffror.Add(2);
            siffror.Add(3);
            siffror.Add(4);
            siffror.Add(5);
            siffror.Add(6);
            siffror.Add(7);
            siffror.Add(8);
            siffror.Add(9);

            //Är den inte statisk måste man skapa ett objekt för att kunna hitta den
            //private/public - Om man FÅR man inte göra  ett  objekt  av det - Andra program ska inte komma åt det

            int count = 0;

            //försöker kodklumen och om den misslyckas hoppar den över till cathen. Tar emot erroret och skrivet ut erroret (som programmerare kan läsa)
            //Try används ofta till errorhantering

            try
            {
                for (int row = 0; row < length; row++)
                {

                }


            }
            catch (global::System.Exception)
            {

                throw;
            }

        }
    }

}
