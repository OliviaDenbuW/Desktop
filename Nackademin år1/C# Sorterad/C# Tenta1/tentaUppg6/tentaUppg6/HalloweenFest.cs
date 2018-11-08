using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg6
{
    public abstract class HalloweenFest : FestKlass
    {
        public bool Utklädnad { get; set; }

        public abstract override int Inträde();
    }
}
