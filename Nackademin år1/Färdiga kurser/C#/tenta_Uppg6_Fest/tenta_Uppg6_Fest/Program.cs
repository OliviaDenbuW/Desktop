using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg6_Fest
{
    class Program
    {
        static void Main(string[] args)
        {
            HalloweenFest halloween = new HalloweenFest();
            Förfest förfest = new Förfest();

            halloween.LokalKostnad = 1000;
            förfest.LokalKostnad = 1000;
            Console.WriteLine(halloween.Inträde());
            Console.WriteLine(förfest.Inträde());


            Console.ReadLine();
        }
    }
}
