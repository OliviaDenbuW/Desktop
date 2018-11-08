using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_GetSet_Tärning
{
    public class Tärning
    {
        private bool cheating;

        public Tärning(bool cheating)
        {
            this.cheating = cheating;
        }

        public void SetCheating(bool value)
        {
            cheating = value;
        } 

        public int RollDiez()
        {
            if (cheating)
            {
                Console.WriteLine("Jag fuskar ALDRIG!");
                return 6;
            }
            else
            {
                Random randomNr = new Random();
                return randomNr.Next(1, 7);
            }
        }
    }
}
