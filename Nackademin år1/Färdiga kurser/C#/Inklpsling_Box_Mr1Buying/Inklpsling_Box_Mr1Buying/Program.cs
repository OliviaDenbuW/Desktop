using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inklpsling_Box_Mr1Buying
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box();
            b.SetWidth(1000);
            b.SetHeight(45);
            
            Console.WriteLine(b.omkrets);
            Console.ReadLine();        
        }
    }
}
