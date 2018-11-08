using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace objectInitializerIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialiserar personobjekt med OBJEKT INITIALISERING
            Person person = new Person
            {
                FirstName = "Olivia",
                LastName = "Denbu"
            };

            Console.WriteLine(person.LastName);
            Console.ReadLine();

        }
    }
}
