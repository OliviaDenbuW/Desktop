using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg6_Fest
{
    class HalloweenFest : Fest
    {
        public bool Utklädnad { get; set; }

        public override decimal Inträde()
        {
            return LokalKostnad * (1.15m);
        }
    }
}
