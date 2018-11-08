using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halloween
{
    public class Förfest : Fest
    {
        private bool medtagEgenDryck;

        public override double Inträde()
        {
            return 0.9 * cost;
        }
    }
}
