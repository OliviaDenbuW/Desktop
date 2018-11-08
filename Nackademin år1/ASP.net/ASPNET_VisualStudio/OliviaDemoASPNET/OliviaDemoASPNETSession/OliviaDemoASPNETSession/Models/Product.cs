using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaDemoASPNETSession.Models
{
    public class Product
    {
        public Product(string name, int id, decimal price)
        {
            this.Name = name;
            this.ID = id;
            this.Price = price;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public decimal Price { get; set; }
    }
}
