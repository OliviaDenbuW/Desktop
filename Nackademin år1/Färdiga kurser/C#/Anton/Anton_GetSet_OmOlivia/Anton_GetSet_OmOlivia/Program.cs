using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_GetSet_OmOlivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Olivia", 25);

            Console.WriteLine(person1.GetAge());

            /*************************************
            person1.SetName("Olivia");
            person1.SetAge(25);

            Console.WriteLine("Her name is {0}", person1.GetName());
            Console.WriteLine("She is {0} years old", person1.GetAge());
            ************************************/
         
            Console.ReadLine();
        }
    }
}
