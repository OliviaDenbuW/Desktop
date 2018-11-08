using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readAndFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa väg till filen
            string pathToFile = "C:\\Users\\Olivia\\Desktop\\Tenta\\" + "Frukter.txt";

            //Det som ska in i filen
            string[] fruits = new string[] { "apple", "pear", "banan", "melon" };

            //Sortera i bokstavsordning
            Array.Sort(fruits);

            //Skapa en variabel för sparade frukter i bokstavsordning
            string sortedFruits = "";

            //Testa skriva ut bokstavsordning i programmet
            for (int i = 0; i < fruits.Length; i++)
            {
                sortedFruits += fruits[i] + " ";
            }
            Console.WriteLine(sortedFruits);

            //Skriv in det i filen
            using (StreamWriter writer = new StreamWriter(pathToFile))
            {
                for (int i = 0; i < fruits.Length; i++)
                {
                    writer.Write(fruits[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
