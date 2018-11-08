using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg2_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Olivia", "Rudsjövägen", 25);
            Console.WriteLine(p1.Namn + " " + p1.Adress + " " + p1.Ålder);

            p1.Adress = "Karla";
            Console.WriteLine(p1.Namn + " " + p1.Adress + " " + p1.Ålder);

            p1.FyllerÅr();
            Console.WriteLine(p1.Namn + " " + p1.Adress + " " + p1.Ålder);

            Console.ReadLine();
        }
    }
}
