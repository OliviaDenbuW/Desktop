using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaDemoASPNETFormulärForts.Models
{
    public class Country
    {
        public Country(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
