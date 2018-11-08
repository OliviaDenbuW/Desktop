using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Metoder_Book1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloName("Olivia");
            Console.ReadLine();
        }

        static void HelloName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
