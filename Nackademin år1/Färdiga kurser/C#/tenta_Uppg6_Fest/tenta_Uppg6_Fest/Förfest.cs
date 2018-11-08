using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg6_Fest
{
    class Förfest : Fest
    {
        public bool MedtagEgenDryck { get; set; }

        public override decimal Inträde()
        {
            return LokalKostnad * (0.9m);
        }
    }
}
