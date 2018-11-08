using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charbel_Frågesport_LINQ_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listDogNames = new List<string>();
            listDogNames.Add("Anna-Maria");
            listDogNames.Add("Olivia");
            listDogNames.Add("Simon");
            listDogNames.Add("Charlie");
            listDogNames.Add("Meya");
            listDogNames.Add("Enya");
            listDogNames.Add("Charbel");
            listDogNames.Add("Fredrik");
            listDogNames.Add("PollyMolly");
            listDogNames.Add("RollyKolly");
            listDogNames.Add("BillyBulli");

            var result1 = from dog in listDogNames
                         where dog.Contains("a") 
                         orderby dog descending
                         select dog;

            var result2 = listDogNames.Where(dog => dog.Contains("a")).OrderByDescending(dog => dog).ToList<string>();

            foreach (var dog5 in result2)
            {
                Console.WriteLine(dog5);
            }
            Console.WriteLine();
            foreach (var dog5 in result1)
            {
                Console.WriteLine(dog5);
            }




            Console.ReadLine();
        }
    }
}
