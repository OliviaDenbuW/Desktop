using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg4_Uppg5_Klubb
{
    class Program
    {
        static void Main(string[] args)
        {
            Medlem m1 = new Medlem();
            m1.FirstName = "Olivia";
            m1.LastName = "Berkefet";
            m1.Personnummer = "911122-0423";

            Medlem m2 = new Medlem();
            Klubb k1 = new Klubb("SolvängenAB", "Solstigen", "Solen", "www.solensUngar@jorden.earth", m1);

            Medlem m3 = new Medlem();
            Klubb k2 = new Klubb("hdhdh", "djjd", "hdhdh", "jdjdj", m3);

            Console.WriteLine(k1.NumberOfMembers());
            k1.NewMember(m2);
            Console.WriteLine(k1.NumberOfMembers());

            k2.NewMember(m1);
            k2.NewMember(m2);
            k2.NewMember(m3);
            Console.WriteLine(k2.NumberOfMembers());
            //k1.Ordförande = m1;
            //Console.WriteLine(k1.Ordförande);

            Console.ReadLine();
        }
    }
}
