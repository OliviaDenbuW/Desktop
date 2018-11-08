using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg3_Kort
{
    class Program
    {
        static void Main(string[] args)
        {
            Kort kort = new Kort(3, 12);
            Console.WriteLine(kort.Färg);
            Console.ReadLine();
        }
    }
}
