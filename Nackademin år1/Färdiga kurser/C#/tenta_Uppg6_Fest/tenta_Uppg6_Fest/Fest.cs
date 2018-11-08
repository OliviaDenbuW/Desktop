using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg6_Fest
{
    abstract class Fest
    {
        public string Namn { get; set; }
        public DateTime Datum { get; set; }
        public decimal LokalKostnad { get; set; }

        public abstract decimal Inträde();
    }
}
