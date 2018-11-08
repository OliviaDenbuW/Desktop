using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta1_Fastigheter
{
    class Villa : Fastighet
    {
        public double TomtYta { get; set; }

        public override decimal FastighetsAvgift()
        {
            decimal avgift = TaxeringsVärde * 0.75m;
            if (avgift > 7112)
            {
                avgift = 7112;
                return avgift;
            }

            return avgift;
        }
    }
}
