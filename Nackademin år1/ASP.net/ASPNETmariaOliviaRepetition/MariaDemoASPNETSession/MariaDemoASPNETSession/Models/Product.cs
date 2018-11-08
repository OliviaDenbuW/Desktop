using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MariaDemoASPNETSession.Models
{
    public class Product
    {
        //Konstruktor
        public Product(int id, string name, decimal price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }

        //properties
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
