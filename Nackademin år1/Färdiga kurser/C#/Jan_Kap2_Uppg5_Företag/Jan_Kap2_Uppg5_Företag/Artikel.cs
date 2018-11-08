using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg5_Företag
{
    class Artikel
    {
        private string beteckning;
        private string beskrivning;
        private int antalArtiklar;
        private decimal försäljningsPris;

        public Artikel(string beteckning, string beskrivning, int antal, decimal pris)
        {
            this.beteckning = beteckning;
            this.beskrivning = beskrivning;
            if (this.antalArtiklar >= 0)
            {
                this.antalArtiklar = antal;
            }
            else
            {
                Console.WriteLine("Felaktigt");
            }
            Pris = this.försäljningsPris;
        }

        public string Beteckning
        {
            get { return this.beteckning; }
        }

        public string Beskrivning
        {
            get { return this.beskrivning; }
        }

        public int Antal
        {
            get { return this.antalArtiklar; }
        }

        public decimal Pris
        {
            get { return this.försäljningsPris; }
            set
            {
                if (value >= 0)
                {
                    this.försäljningsPris = value;
                }
                else
                {
                    Console.WriteLine("Felaktigt pris");
                }
            }
        }

        public void KöpaInArtiklar(int antalSomKöpsIn)
        {
            if (antalSomKöpsIn > 0)
            {
                this.antalArtiklar = this.antalArtiklar + antalSomKöpsIn;
            }
            else
            {
                Console.WriteLine("Felaktigt");
            }
        }

        public void SäljaArtikel(int antalSomSäljs)
        {
            if ((antalSomSäljs > this.antalArtiklar) && (antalSomSäljs > 0))
            {
                Console.WriteLine("Finns inte så många på lager");
            }
            else
            {
                this.antalArtiklar = this.antalArtiklar - antalSomSäljs;
            }
        }
    }
}
