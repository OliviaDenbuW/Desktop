using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halloween
{
    public class Halloweenfest : Fest
    {
        private bool utklädnad;

        public override double Inträde()
        {
            return 1.15 * cost;
        }
    }
}
