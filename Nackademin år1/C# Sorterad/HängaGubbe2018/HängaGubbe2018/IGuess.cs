using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HängaGubbe2018
{
    public interface IGuess
    {
        bool IsCorrectGuess(string typeOfGuess);

        bool GuessIsALetter();

        //Vet ej returneringstyp Word/Letter
        void GetTypeOfGuess();

    }
}
