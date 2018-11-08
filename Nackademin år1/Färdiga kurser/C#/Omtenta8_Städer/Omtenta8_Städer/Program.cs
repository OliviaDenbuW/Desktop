using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta8_Städer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Stockholm", "Göteborg", "Malmö", "Köpenhamn", "London" };


            var result = cities.Select(x => x.Length).Sum();

            Console.WriteLine(result);
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //var result = from x in cities
            //             where (x.)

            //foreach (var city in cities)
            //{
            //    int nrOfLetters = city.Count<char>();
            //    Console.WriteLine(nrOfLetters);
            //}              

            Console.ReadLine();
        }
    }
}
