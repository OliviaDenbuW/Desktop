using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Customer_Kudvenkat
{
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Customer c = new Program();
            c.Hello();
            c.Print();

            Console.ReadLine();
        }

        public override void Print()
        {
            Console.WriteLine("Print Message");
        }
    }
}
