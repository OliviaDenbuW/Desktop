using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamen_Fest
{
    public class Halloweenfest : Fest
    {
        protected bool utklädnad;

        public override double Inträde()
        {
            return 1.15 * lokalkostand;
        }
    }
}
