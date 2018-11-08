using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_Konstruktor_NyföddOchFavoritMat
{
    public class Person
    {
        private string name;
        private int age;
        private string favouriteFood;

        public Person()
        {
            this.name = "Alice";
            this.age = 0;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }

        public int Birthday()
        {
            return age = age + 1;
        }
    }
}
