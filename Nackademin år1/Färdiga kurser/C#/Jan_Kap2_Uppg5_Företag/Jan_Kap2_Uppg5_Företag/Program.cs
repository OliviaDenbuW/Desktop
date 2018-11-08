using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg5_Företag
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikel a = new Artikel("9999jeke", "Fin båt", 199, 100000000.0m);

            Console.WriteLine(a.Beskrivning + " " + a.Beteckning + " " + a.Antal + " " + a.Pris);
            a.KöpaInArtiklar(-1);
            a.KöpaInArtiklar(19999);
            Console.WriteLine(a.Antal);
            a.SäljaArtikel(199999999);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
