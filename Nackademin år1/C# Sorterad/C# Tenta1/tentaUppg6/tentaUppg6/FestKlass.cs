using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg6
{
    public abstract class FestKlass
    {
        public string Namn { get; set; }
        public DateTime Datum { get; set; }
        public int Lokalkostnad { get; set; }

        public abstract int Inträde();
    }
}
