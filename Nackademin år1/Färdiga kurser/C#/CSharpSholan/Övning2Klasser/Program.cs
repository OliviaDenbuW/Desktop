using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();

            Console.Write("First name: ");
            name.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            name.LastName = Console.ReadLine();

            Console.Write("Your complete name is: {0}", name.CompleteName);
           
            Console.ReadLine();
        }
    }
}
