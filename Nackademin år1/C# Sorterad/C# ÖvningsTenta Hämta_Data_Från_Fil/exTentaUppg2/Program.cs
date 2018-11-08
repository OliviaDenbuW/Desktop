using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exTentaUppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            string unSortedString = "231596874";
            string sortedString = "";
            char[] unsortedChar = unSortedString.ToArray();
            Array.Sort(unsortedChar);

            for (int i = 0; i < unSortedString.Length; i++)
            {
                sortedString += unsortedChar[i];
            }
            //Console.WriteLine(sortedString);

            var pathToFile = "C:\\Users\\Olivia\\Desktop\\Tenta\\Tal.txt";
            using (StreamWriter writer = new StreamWriter(pathToFile))
            {
                writer.WriteLine("Sorted string: {0}", sortedString);

            }

            using (StreamReader reader = new StreamReader(pathToFile))
            {
                string row = reader.ReadLine();
                Console.WriteLine(row);
            }

            Console.ReadLine();
        }
    }
}
