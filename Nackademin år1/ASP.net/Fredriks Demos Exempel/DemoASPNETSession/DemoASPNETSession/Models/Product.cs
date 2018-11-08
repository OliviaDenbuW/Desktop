using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoASPNETSession.Models
{
    public class Product
    {
        public Product(string name, int id, int price)
        {
            Name = name;
            ID = id;
            Price = price;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public int Price { get; set; }
    }
}
