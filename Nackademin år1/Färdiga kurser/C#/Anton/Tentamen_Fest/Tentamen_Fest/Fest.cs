using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamen_Fest
{
    public abstract class Fest
    {
        public string namn { get; set; }
        public DateTime datum { get; set; }
        public double lokalkostand { get; set; }

        public abstract double Inträde();

        public void SetLokalkostnad(double lokalkostnad)
        {
            this.lokalkostand = lokalkostand;
        }

        public double GetInträdesKostnad()
        {

        }
    }
}
