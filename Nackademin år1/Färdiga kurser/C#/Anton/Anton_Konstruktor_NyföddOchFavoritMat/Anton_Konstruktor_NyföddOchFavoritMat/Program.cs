using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Konstruktor_NyföddOchFavoritMat
{
    class Program
    {
        static void Main(string[] args)
        {
            Person nyfödd = new Person();

            Console.WriteLine("En nyföddbebis är {0} år", nyfödd.GetAge());
            Console.WriteLine("Hon heter {0} tills hennes föräldrar döpt henne", nyfödd.GetName());

            int newAge = nyfödd.Birthday();

            Console.WriteLine("Det har gått ett helt år. Nu är hon {0} år gammal!!!!", newAge);
            Console.ReadLine();
        }
    }
}
