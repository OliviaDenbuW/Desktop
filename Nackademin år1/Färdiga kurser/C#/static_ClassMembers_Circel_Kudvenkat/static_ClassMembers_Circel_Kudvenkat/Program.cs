using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_ClassMembers_Circel_Kudvenkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area1 = c1.CalculateArea();

            Circle c2 = new Circle(6);
            float area2 = c2.CalculateArea();
            Console.WriteLine(area1);
            Console.WriteLine(area2);
            Console.ReadLine();
        }
    }
}
