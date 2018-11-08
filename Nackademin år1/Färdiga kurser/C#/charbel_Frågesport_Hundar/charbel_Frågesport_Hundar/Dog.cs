using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charbel_Frågesport_Hundar
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Dog(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
        }
    }
}
