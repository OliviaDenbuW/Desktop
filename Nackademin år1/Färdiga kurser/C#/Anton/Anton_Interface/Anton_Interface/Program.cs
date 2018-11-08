using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //Console.WriteLine(list.Size());

            list.Add(2);
            list.Add(4);
            list.Add(8);
            Console.WriteLine(list.Size());
            list.Clear();
            Console.WriteLine(list.Size());

            Console.WriteLine(list.Get(1));
            Console.ReadLine();
        }
    }
}
