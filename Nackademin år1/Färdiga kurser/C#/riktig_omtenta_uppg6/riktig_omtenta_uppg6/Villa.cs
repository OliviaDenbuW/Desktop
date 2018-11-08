using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg6
{
    class Villa : Fastighet
    {
        public double TomtTya { get; set; }

        public override decimal Fastighetsavgift()
        {
            if ((Taxeringsvärde * (0.75m)) > 7112)
            {
                return 7112.00m;
            }

            return Taxeringsvärde * (0.75m);
        }
    }
}
