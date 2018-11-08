using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg6
{
    abstract class Fastighet
    {
        public double BoYta { get; set; }
        public decimal Taxeringsvärde { get; set; }

        public abstract decimal Fastighetsavgift();
    }
}
