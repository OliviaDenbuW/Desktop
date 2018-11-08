using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charbel_Frågesport_Hundar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> listDogs = new List<Dog>();

            /*Dog d1 = new Dog("hh", 2, "hh");
            listDogs.Add(d1);*/

            listDogs.Add(new Dog("Anna-maria", 2, "Chiuaua"));
            listDogs.Add(new Dog("Charbel", 12, "Rottweiler"));
            listDogs.Add(new Dog("Olivia", 6, "Pitbull"));
            listDogs.Add(new Dog("Ojjjjlivia", 45, "Pitbull"));

            var result1 = from dog in listDogs
                         where dog.Name.Contains("a") &&
                         dog.Breed.Equals("Pitbull") &&
                         dog.Age > 5
                          orderby dog.Name descending
                          select dog;

            var result3 = listDogs.Where(dog => dog.Name.Contains("a") && dog.Breed.Equals("Pitbull") && dog.Age > 5).OrderByDescending(n => n.Age);

            //List<Dog> hundar = result1.ToList<Dog>();

            var result2 = from dog in listDogs.OfType<Dog>()
                         orderby dog ascending
                         select dog;

            foreach (var dog in result3)
            {
                Console.WriteLine(dog.Name);
                Console.WriteLine(dog.Age);
            }
            Console.ReadLine();
        }
    }
}
