using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta4_Företag
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Charbel", "djdhdh", "jhdhjdjh");
            Person p2 = new Person("Maria", "ddkd", "jdjdj");
            Person p3 = new Person("19911122-0423", "Olivia", "Denbu");

            Företag f1 = new Företag("OliviaAB", "Rudan", "Nacka", "Olivia@snabela.se");
            Företag f2 = new Företag("CharbelAB", "jdhd", "hdhd", "cjhdh");

            f1.NyAnställd(p1);
            f1.NyAnställd(p3);

            f2.NyAnställd(p2);

            Console.WriteLine(f1.AntalAnställda());
            Console.WriteLine(f2.AntalAnställda());
            
            Console.ReadLine();
        }
    }
}
