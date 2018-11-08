using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubb
{
    class Program
    {
        static void Main(string[] args)
        {
            Klubb klubb = new Klubb("AHS", "hdhd", "hdhd", "jdjd");
            Medlem m1 = new Medlem();
            Medlem m2 = new Medlem();
            Medlem m3 = new Medlem();

            klubb.SetOrdförande(m1);

            klubb.NyMedlem(m2);
            klubb.NyMedlem(m3);
            
            Console.WriteLine(klubb.AntalMedlemmar());
            Console.ReadLine();
        }
    }
}
