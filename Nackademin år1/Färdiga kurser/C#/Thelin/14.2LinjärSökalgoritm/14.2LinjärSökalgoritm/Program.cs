using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2LinjärSökalgoritm
{
    //==========================KLASS==================================
    //Program. Här ligger huvudfunktionaliteten i programmet. Innehåller
    //exempel på linjär sökning
    //=================================================================
    class Program
    {
        //=======================MAIN=================================
        //Main. Start på programmet.
        //============================================================
        static void Main(string[] args)
        {
            //Skapa en lista av typen person
            List<Person> myList = new List<Person>();

            //Fyll på listan med personer. Med hjälp av ordet new och
            //konstruktorn i klassen Person, så kan vi skapa dem direkt
            //i metoden Add. Vi är noga med att lägga dem i ordning
            //efter personnummer:
            myList.Add(new Person("Lisa", 330112));
            myList.Add(new Person("Pelle", 420721));
            myList.Add(new Person("Fia", 421221));
            myList.Add(new Person("Nisse", 691122));
            myList.Add(new Person("Kalle", 811126));
            myList.Add(new Person("Klara", 840717));
            myList.Add(new Person("Maja", 920411));
            myList.Add(new Person("Stina", 940723));
            myList.Add(new Person("Olle", 950318));

            //Låt användaren mata in personnummer:
            Console.Write("Ange personnummer att söka i: ");
            string str = Console.ReadLine();
            int key = Convert.ToInt32(str);

            //Sök efter personen:
            int index = LinearSearch(myList, key);

            //Skriv ut resultat
            if (index == -1)
            {
                Console.WriteLine("Personen fanns inte");
            }
            else
            {
                Console.WriteLine("Personen med personnummer {0} finns på index {1} och heter {2}", key, index, myList[index].Name);
            }
            Console.ReadLine();
        }

        //=======================METOD=================================
        //LinearSearch. Tar emot en lista av typen Person (sorterad eller
        //osorterad spelar ingen roll) och ett heltal, key, att söka efter
        //i listan. Metoden söker efter ett personnummer i listan som 
        //matchar key. Om inget personnummer finns i listan som stämmer
        //överens med key så returneras -1.
        static int LinearSearch(List<Person> list, int key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //Gå igenom listan, element för element, och se om key går att hitta
                //Listan består alltså av personer
                if (list[i].Personnummer == key)
                {
                    return i;
                }
            }
            //Kommer vi hit har hela listan gåtts igenom utan att key har hittats
            return -1;
        }
    }
}
