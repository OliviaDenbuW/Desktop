using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exTentaUppg5_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogArray = new Dog[2];
            Dog dog1 = new Dog();

            Console.WriteLine("Antal hundar: {0}", Dog.counter);
            Console.ReadLine();
        }
    }
}
