using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charbel_Frågesport1_CSharp
{
    public class Hus
    {
        public string Colour { get; set; }
        public int NrOfToilettes { get; set; }
        public static int counterHouse;

        public Hus()
        {
            Console.WriteLine("Ett hus skapas");
            counterHouse++;
        }

        public Hus(string colour, int nrOfToilettes)
        {
            this.Colour = colour;
            this.NrOfToilettes = nrOfToilettes;
            counterHouse++;
        }

        public static void GetNumberOfHouses()
        {
            Console.WriteLine(counterHouse);
        }
    }
}
