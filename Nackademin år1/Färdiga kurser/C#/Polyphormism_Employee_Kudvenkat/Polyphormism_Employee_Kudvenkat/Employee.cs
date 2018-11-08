using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyphormism_Employee_Kudvenkat
{
    class Employee
    {
        public string FN = "FN";
        public string LN = "LN";
        public string email;

        public virtual void PrintFullName()
        {
            Console.WriteLine(FN + " " + LN);
        }

    }
}
