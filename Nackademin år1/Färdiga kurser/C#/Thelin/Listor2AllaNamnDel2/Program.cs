using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listor2AllaNamnDel2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Name {0}: ", i+1);
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine();

            bool wantToChangeName = true;
            do
            {
                Console.Write("Do you want to change a name? (y/n)");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    Console.Write("Index of the name you want to erase: ");
                    string inputIndex = Console.ReadLine();
                    int index = int.Parse(inputIndex);

                    if (names.Contains(index))
                }



                //} while (wantToChangeName);

                Console.ReadLine();
        }
    }
}
