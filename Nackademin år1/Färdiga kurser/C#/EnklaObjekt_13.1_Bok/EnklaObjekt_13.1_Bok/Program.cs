using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnklaObjekt_13._1_Bok
{
    class Program
    {
        static void Main(string[] args)
        {
            Bok b1 = new Bok("Jan Skoglund", 32, 16766);

            Console.WriteLine("Författare: " + b1.GetName());
            Console.WriteLine("Antal sidor: " + b1.GetAntalSidor());
            Console.WriteLine("Pris: " + b1.GetPris());
            Console.ReadLine();
        }
    }
}
