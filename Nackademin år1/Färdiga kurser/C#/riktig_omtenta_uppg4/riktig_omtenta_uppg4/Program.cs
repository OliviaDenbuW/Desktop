using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Employee();
            Organization organization = new Organization("OliviaAB", "Rudjsövägen 51", "Solen", "www.solens@änglar.se", manager);

            Console.ReadLine();
        }
    }
}
