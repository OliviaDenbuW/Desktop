using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fredag
{
    class Program
    {
        private int age;
        private string name;
        private string favouriteFood



        public Program (string name, int age)
        {
            this.name = name;
            SetAge(age);
        }

        public void setFavouriteFood(string favouriteFood)
        {
            this.favouriteFood = favouriteFood;
        }

        public string getFavouriteFood()
        {
            return this.favouriteFood;
        }

        public string GetName()
        {
            return name;
        }

        public void Birthday()
        {
            this.age = this.age + 1;
            //age++;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        static void Main(string[] args)
        {
            Program main = new Program("Olivia", 25);

            main.setFavouriteFood("Panncakes");
            Console.WriteLine(main.getFavouriteFood()); 

            main.SetAge(33);
            Console.WriteLine(main.GetAge());
            Console.ReadLine();

        }
    }
}
