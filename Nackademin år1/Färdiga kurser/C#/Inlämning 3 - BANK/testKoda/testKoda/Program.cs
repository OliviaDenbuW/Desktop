using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testKoda
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> infoList = new List<string>();




            Console.WriteLine("Nr: ");
            string str = Console.ReadLine();

            if (12 == double.Parse(str))
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("not");
            }

            /*do
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                infoList.Add(name);

                Console.WriteLine("Country: ");
                string country = Console.ReadLine();
                infoList.Add(country);

                foreach (var info in infoList)
                {
                    Console.WriteLine(info);
                }

                Console.WriteLine("Correct? (yes/no)");
                string answer = Console.ReadLine();

                if (answer == "yes".ToLower()) ;
                correctInput = true;
            } while (!correctInput);*/
            /*
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6 };

            var searchResult = numberList.FindAll(numbers => (numbers % 2 == 0));

            foreach (var number in searchResult)
            {
                Console.WriteLine(number);
                if (number == 4)
                {
                    break;
                }
            }*/


            Console.ReadLine();
        }
    }
}
