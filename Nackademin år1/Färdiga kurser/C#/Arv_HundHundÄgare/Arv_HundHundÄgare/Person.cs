using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_HundHundÄgare
{
    class Person
    {
        protected string Name { get; set; }
        protected string Adress { get; set; }
        protected string Telephone { get; set; }

        public Person(string name, string adress, string telephone)
        {
            this.Name = name;
            this.Adress = adress;
            this.Telephone = telephone;
        }
    }
}
