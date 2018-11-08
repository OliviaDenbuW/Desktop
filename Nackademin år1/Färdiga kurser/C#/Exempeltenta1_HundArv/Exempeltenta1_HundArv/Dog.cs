using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempeltenta1_HundArv
{
    class Dog
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public DogOwner owner { get; set; }

        static int nrOfDogs = 0;

        public Dog(string name, string colour, DogOwner owner)
        {
            this.Name = name;
            this.Colour = colour;
            this.owner = owner;

            nrOfDogs++;
        }
    }
}
