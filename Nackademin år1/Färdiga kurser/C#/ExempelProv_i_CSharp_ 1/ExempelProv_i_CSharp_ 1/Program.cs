using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempelProv_i_CSharp__1
{
    class Program
    {
        enum årstid {Vinter, Vår, Sommar, Höst};

        static void Main(string[] args)
        {
            var förstaÅrstiden = (int)årstid.Höst;
            var andraÅrstiden = årstid.Vår;

            Console.WriteLine(förstaÅrstiden);
            Console.WriteLine(andraÅrstiden);
            Console.ReadLine();
        }
    }
}
