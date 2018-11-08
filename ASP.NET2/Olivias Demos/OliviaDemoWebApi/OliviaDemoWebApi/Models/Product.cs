using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaDemoWebApi.Models
{
    public class Product
    {
        public Product(string name, int id, int price)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
    }
}
