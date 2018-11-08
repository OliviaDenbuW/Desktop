using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charbel_Frågesport1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hus hus1 = new Hus("red", 4);
            Hus hus2 = new Hus();

            Hus.GetNumberOfHouses();
            Console.ReadLine();
        }

      
    }
}
