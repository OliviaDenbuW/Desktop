using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamen_Klubb
{
    class Program
    {
        static void Main(string[] args)
        {
            Klubb klubb = new Klubb();
            Medlem ordförande = new Medlem();

            klubb.SetOrdförande(ordförande);

            /*
            klubb.adress = "Rudsjövägen 51";
            Console.WriteLine("Klubbens adress är {0}", klubb.adress);
            */
            Console.ReadLine();
        }
    }
}
