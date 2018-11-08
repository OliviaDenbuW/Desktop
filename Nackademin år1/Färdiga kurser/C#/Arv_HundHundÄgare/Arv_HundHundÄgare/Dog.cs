using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_HundHundÄgare
{
    class Dog
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public DogOwner Owner { get; set; }

        private static int nrOfDogs = 0;
        
        public Dog(string name, string colour, DogOwner owner)
        {
            this.Name = name;
            this.Colour = colour;
            this.Owner = owner;

            nrOfDogs++;
        }

        public static int GetDogs()
        {
            return nrOfDogs;
        }
    }
}
