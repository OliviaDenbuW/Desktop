using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg3_Kort
{
    class Kort
    {
        private int färg;   //1=klöver, 2=ruter, 3=hjärter, 4=spader 
        private int valör;

        public Kort(int färg, int valör)
        {
            if (färg < 1 || färg > 4 || valör < 1 || valör > 13)
            {
                Console.WriteLine("Felaktig initiering");
                färg = valör = 1;
            }
            else
            {
                this.färg = färg;
                this.valör = valör;
            }
        }


        public int Färg
        {
            get { return this.färg; }
        }

        public int Valör
        {
            get { return this.valör; }
        }

        public override string ToString()
        {
            string text;

            if (färg == 1)
            {
                text = "Klöver ";
            }
            else if (färg == 2)
            {
                text = "Ruter ";
            }
            else if (färg == 3)
            {
                text = "Hjärter ";
            }
            else
            {
                text = "Spader ";
            }


            if (valör == 1)
            {
                text = text + "Ess";
            }
            else if (valör < 11)
            {
                text = text + valör;
            }
            else if (valör == 11)
            {
                text = text + "Knekt";
            }
            else if (valör == 12)
            {
                text = text + "Dam";
            }
            else
            {
                text = text + "Kung";
            }
            return text;
        }
    }
}
