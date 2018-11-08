using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyphormism_Employee_Kudvenkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arrayEmployees = new Employee[4];

            arrayEmployees[0] = new Employee();
            arrayEmployees[1] = new PartTimeEmployee();
            arrayEmployees[2] = new FullTimeEmployee();
            arrayEmployees[3] = new TemporaryEmployee();

            foreach (Employee e in arrayEmployees)
            {
                e.PrintFullName();
            }
            Console.ReadLine();
        }
    }
}
