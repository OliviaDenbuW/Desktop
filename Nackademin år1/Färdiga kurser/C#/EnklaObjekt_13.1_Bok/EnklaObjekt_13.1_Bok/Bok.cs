using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnklaObjekt_13._1_Bok
{
    public class Bok
    {
        public string Författare { get; set; }
        public int AntalSidor { get; set; }
        public double Pris { get; set; }

        public Bok(string författare, int antalSidor, double pris)
        {
            this.Författare = författare;
            this.AntalSidor = antalSidor;
            this.Pris = pris;
        }

        public string GetName()
        {
            return Författare;
        }

        public int GetAntalSidor()
        {
            return AntalSidor;
        }

        public double GetPris()
        {
            return Pris;
        }
    }
}
