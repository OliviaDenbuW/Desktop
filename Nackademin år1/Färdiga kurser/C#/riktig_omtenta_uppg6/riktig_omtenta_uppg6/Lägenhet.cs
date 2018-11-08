using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg6
{
    class Lägenhet :  Fastighet
    {
        public int LägenhetsNummer { get; set; }

        public override decimal Fastighetsavgift()
        {
            if ((Taxeringsvärde * (0.3m)) > 1217)
            {
                return 1217.00m;
            }

            return Taxeringsvärde * (0.3m);
        }
    }
}
