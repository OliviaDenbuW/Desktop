using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning1Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Brand = "BMW";
            car1.Colour = "Black";
            car1.Model = "Big";
            car1.Origin = "Germany";

            Console.WriteLine(car1.Brand);
            Console.ReadLine();
        }
    }
}
