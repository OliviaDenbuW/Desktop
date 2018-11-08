using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Employee_Kudvenkat
{
    class Employee
    {
        public string FN;
        public string LN;
        public string email;

        public Employee()
        {
            Console.WriteLine("Employee constructor called");
        }

        public Employee(string message)
        {
            Console.WriteLine(message);
        }
        
        private void PrintFullName()
        {
            Console.WriteLine("Fullname: {0} {1}", FN, LN);
        }
    }
}
