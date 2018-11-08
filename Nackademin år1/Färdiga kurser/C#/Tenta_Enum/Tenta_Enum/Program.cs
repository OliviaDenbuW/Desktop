using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_Enum
{
    class Program
    {
        enum KontaktTyp { Privat, Jobb, Övrigt }

        static void Main(string[] args)
        {
            KontaktTyp a = KontaktTyp.Jobb;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
