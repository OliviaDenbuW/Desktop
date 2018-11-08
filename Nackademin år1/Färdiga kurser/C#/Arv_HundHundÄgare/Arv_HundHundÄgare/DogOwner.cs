using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_HundHundÄgare
{
    class DogOwner : Person
    {
        Dog[] dogs = new Dog[2];

        public DogOwner(string name, string adress, string telephone) : base (name, adress, telephone)
        {
            dogs[0] = new Dog("Hooly", "brown", this);
            dogs[1] = new Dog("Billy", "white", this);
        }
    }
}
