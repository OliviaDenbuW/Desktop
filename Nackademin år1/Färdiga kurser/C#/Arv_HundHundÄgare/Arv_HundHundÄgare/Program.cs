using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_HundHundÄgare
{
    class Program
    {
        static void Main(string[] args)
        {
            DogOwner person1 = new DogOwner("Olivia", "rudan", "93838");

            Console.WriteLine(Dog.GetDogs());
            Console.ReadLine();
        }
    }
}
