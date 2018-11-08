using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listNames = new List<string>();

            listNames.Add("Olivia");
            listNames.Add("Malvia");
            listNames.Add("Bivia");
            listNames.Add("Andivia");
            listNames.Add("Josvia");
            listNames.Add("Monvia");

            var result1 = from name in listNames
                         //where name.StartsWith("M")
                         orderby name ascending
  
                         
            foreach (var name in result2)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
