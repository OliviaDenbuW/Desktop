using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Customer_Kudvenkat
{
    public abstract class Customer
    {
        public abstract void Print();

        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
