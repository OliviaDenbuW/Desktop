using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg1_Räknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Räknare r = new Räknare(100);
            Console.WriteLine(r.Värde);

            r.ÖkaRäknare();
            Console.WriteLine(r.Värde);

            r.Värde = 25;
            Console.WriteLine(r.Värde);

            r.MinskaRäknare();
            Console.WriteLine(r.Värde);

            r = new Räknare(1, 0, 10);
            r.MinskaRäknare();
            Console.WriteLine(r.Värde);
            r.MinskaRäknare();
            Console.WriteLine(r.Värde);

            r.Värde = 10;
            Console.WriteLine(r.Värde);
            r.ÖkaRäknare();

            r = new Räknare(0, 0, -1);
            r = new Räknare(0, 1, 10);
            
            Console.ReadLine();
        }
    }
}
