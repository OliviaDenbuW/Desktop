using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta1_Fastigheter
{
    class Lägenhet : Fastighet
    {
        public int LägenhetsNummer { get; set; }

        public override decimal FastighetsAvgift()
        {
            decimal avgift = TaxeringsVärde * 0.30m;
            if (avgift > 1217)
            {
                avgift = 1217;
                return avgift;
            }

            return avgift;
        }
    }
}
