using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_GetSet_Tärning
{
    class Program
    {
        static void Main(string[] args)
        {
            Tärning person1 = new Tärning(false);
            
            Console.WriteLine("Omgång 1:");
            Console.WriteLine(person1.RollDiez());

            Console.WriteLine("Omgång 2:");
            person1.SetCheating(true);
            Console.WriteLine(person1.RollDiez());

            Console.ReadLine();
        }
    }
}
