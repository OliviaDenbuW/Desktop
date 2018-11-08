using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg1_Räknare
{
    class Räknare
    {
        private int värde;
        private int minstaVärde;
        private int störstaVärde;

        public Räknare(int startVärde)
        {
            this.minstaVärde = int.MinValue;
            this.störstaVärde = int.MaxValue;
            this.värde = startVärde;
        }

        public Räknare(int startVärde, int minstaVärde, int störstaVärde)
        {
            if (minstaVärde <= störstaVärde)
            {
                this.minstaVärde = minstaVärde;
                this.störstaVärde = störstaVärde;
                this.värde = startVärde;
            }

        }

        public int Värde
        {
            get { return värde; }
            set
            {
                if (value >= minstaVärde && value <= störstaVärde)
                {
                    värde = value;
                }

                else
                {
                    Console.WriteLine("Ogiltiga värden");
                }
            }
        }

        public void ÖkaRäknare()
        {
            Värde = värde + 1;
        }

        public void MinskaRäknare()
        {
            Värde = värde - 1;
        }
    }
}
