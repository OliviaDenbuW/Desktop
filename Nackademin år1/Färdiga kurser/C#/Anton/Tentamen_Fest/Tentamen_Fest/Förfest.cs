using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamen_Fest
{
    public class Förfest : Fest
    {
        protected bool medtagenDryck;

        public override double Inträde()
        {
            return 0.9 * lokalkostand;
        }
    }
}
