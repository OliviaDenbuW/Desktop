using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halloween
{
    class Program
    {
        static void Main(string[] args)
        {
            Förfest obj1 = new Förfest();
            Halloweenfest obj2 = new Halloweenfest();

            obj1.SetCost(1100);
            obj2.SetCost(2000);

            Console.WriteLine("Förfest: {0}", obj1.Inträde());
            Console.Write("Halloween: {0}", obj2.Inträde());
            Console.ReadLine();

        }
    }
}
