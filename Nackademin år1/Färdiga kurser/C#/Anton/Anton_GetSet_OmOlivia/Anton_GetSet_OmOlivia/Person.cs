using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_GetSet_OmOlivia
{
    public class Person
    {
        private string name;
        private int age;
        private string favouriteFood;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
