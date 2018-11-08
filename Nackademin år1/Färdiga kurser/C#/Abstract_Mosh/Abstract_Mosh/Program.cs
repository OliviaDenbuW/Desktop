using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Mosh
{
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();

            Customer c = new Program();
            double diff = c.Difference();

            Console.WriteLine(diff);
            Console.ReadLine();
        }

        public override void Print()
        {
            Console.WriteLine("Print Message");
        }

        public override double Difference()
        {
            return 13.9 + 2.4;
        }
    }
}
