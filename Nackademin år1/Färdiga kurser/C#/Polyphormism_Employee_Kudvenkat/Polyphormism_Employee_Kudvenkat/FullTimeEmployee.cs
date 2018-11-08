using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyphormism_Employee_Kudvenkat
{
    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FN + " " + LN + " - Full Time");
        }
    }
}
