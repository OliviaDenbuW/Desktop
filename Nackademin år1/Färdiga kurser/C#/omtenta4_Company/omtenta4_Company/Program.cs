using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omtenta4_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Olivia";

            Person p2 = new Person();
            p2.FirstName = "Maria";

            Company c1 = new Company("OliviaAB", "Rudsjövägen", "Nacka", "www.ab.se", p1);

            //c1.NewEmployee(p2);
            Console.WriteLine(c1.NrOfEmployees());

            //c1.Owner = p1;
            //Console.WriteLine(c1.Owner.FirstName);

            Console.ReadLine();
        }
    }
}
