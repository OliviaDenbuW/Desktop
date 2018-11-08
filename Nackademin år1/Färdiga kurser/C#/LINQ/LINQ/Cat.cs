using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Colour { get; set; }
        //List<Cat> cats;

        public Cat(string name, string colour, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
        }

        //public Cat()
        //{
        //    this.cats = new List<Cat>();
        //}

        //public void NewCat(Cat cat)
        //{
        //    cats.Add(cat);
        //}

        //public int NrOfCats()
        //{
        //    return cats.Count();
        //}
    }
}
