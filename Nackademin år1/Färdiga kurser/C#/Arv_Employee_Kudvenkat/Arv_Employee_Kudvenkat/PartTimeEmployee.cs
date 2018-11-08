using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Employee_Kudvenkat
{
    class PartTimeEmployee : Employee
    {
        public decimal hourlyRate;

        public PartTimeEmployee() : base("Derrived class controlling parent class")
        {
            Console.WriteLine("PartTimeEmployee called");
        }
    }
}
