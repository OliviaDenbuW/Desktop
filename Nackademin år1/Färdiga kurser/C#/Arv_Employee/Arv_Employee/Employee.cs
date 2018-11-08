using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Employee
{
    class Employee
    {
        public string FN { get; set; }
        public string LN { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine(FN + LN);
        }
    }
}
