using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempeltenta1_EnumÅrstider
{
    class Program
    {
        enum årstider { vinter, vår, sommar, höst}

        static void Main(string[] args)
        {
            var metod = (int)årstider.sommar;
            Console.WriteLine(metod);
            Console.ReadLine();
        }
    }
}
