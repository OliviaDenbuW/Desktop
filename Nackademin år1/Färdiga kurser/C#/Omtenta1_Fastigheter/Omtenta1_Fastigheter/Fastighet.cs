using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta1_Fastigheter
{
    abstract class Fastighet
    {
        public double BoYta { get; set; }
        public decimal TaxeringsVärde { get; set; }

        public abstract decimal FastighetsAvgift();
    }
}
