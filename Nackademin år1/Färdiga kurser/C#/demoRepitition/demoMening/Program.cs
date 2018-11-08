using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoMening
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string sökvärde = "a";
            string mening = "Jag har en lång mening där en del ord innhåller ett a och ingenting annat";

            string[] ordarray = mening.Split();

            int antal = 0;

            for (int i = 0; i < ordarray.Length; i = i+1)
            {
                string ord = ordarray[i];
                bool finnsSökvärdeIOrd = ord.Contains(sökvärde);
                if (finnsSökvärdeIOrd) antal = antal + 1; //antal++
            }

            antal = 0;
            foreach (string ord in ordarray)
            {
                bool finnsSökvärdeIOrd = ord.Contains(sökvärde);
                if (finnsSökvärdeIOrd) antal = antal + 1; //antal++
            }

            bool finnsSökvärdeiMening = mening.Contains(sökvärde);

            int indexAvSökvärde = mening.IndexOf(sökvärde);

        }
    }
}
