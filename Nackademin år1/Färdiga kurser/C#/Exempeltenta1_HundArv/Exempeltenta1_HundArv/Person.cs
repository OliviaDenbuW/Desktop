using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempeltenta1_HundArv
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }

        public Person(string name, string address, int telephone)
        {
            this.Name = name;
            this.Address = address;
            this.Telephone = telephone;
        }
    }
}
