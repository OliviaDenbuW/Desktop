using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);

            Console.ReadLine();
        }
    }
}
