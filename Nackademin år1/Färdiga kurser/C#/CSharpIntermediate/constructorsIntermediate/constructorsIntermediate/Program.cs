using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorsIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar INSTANS av klassen Customer
            Customer customer = new Customer();

            customer.Id = 1;
            customer.Name = "John";

            Order order = new Order();

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            Console.ReadLine();     
            
        }
    }
}
