using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Konstruktor_OmOlivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Olivia", 25);

            Console.WriteLine(person1.GetName());
            person1.SetName("Felle");
            Console.WriteLine(person1.GetName());
            Console.ReadLine();
        }
    }
}
