using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorMosh
{
    public class Customer
    {
        //deklarerar fiels (i vanliga fall är de privata)
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
        }

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
