using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoASPNETFormulärForts.Models
{
    public class Country
    {
        public Country(int id , string name)
        {
            ID = id;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
