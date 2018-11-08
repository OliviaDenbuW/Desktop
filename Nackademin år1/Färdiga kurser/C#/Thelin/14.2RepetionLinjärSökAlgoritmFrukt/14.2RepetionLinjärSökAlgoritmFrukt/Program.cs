using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2RepetionLinjärSökAlgoritmFrukt
{
    //========================KLASS===============================
    //Program. Här ligger huvudfunktionaliteten i programmet.
    //Programmet innehåller linjär sökfunktion applicerat på frukt
    //============================================================
    class Program
    {
        //=========================METOD===========================
        //Main. Start på programmet.
        //=========================================================
        static void Main(string[] args)
        {
            //Skapa en lista av typen Frukt
            List<Frukt> myList = new List<Frukt>();

            //Fyll på listan med frukter
            myList.Add(new Frukt("banan", "Yellow", 12.5));
            myList.Add(new Frukt("Päron", "Green", 34.1));
            myList.Add(new Frukt("Vindruvor", "Lila", 54.9));

            //Ta in namn på sökt frukt
            Console.Write("Namn på frukt du söker kilopris: ");
            string inputFrukt = Console.ReadLine();
            int index = LinearSearch(myList, inputFrukt);

            if(index == -1)
            {
                Console.Write("Frukten du söker finns inte hos oss");
            }
            else
            {
                Console.Write("{0} är {1} och kostar {2}kr/kg", inputFrukt, myList[index].Color, myList[index].PricePerKg);
            }
            Console.ReadLine();
        }

        //=========================METOD============================
        //LinearSearch. Här tar vi emot en lista av frukter. 
        //Vi måste ha listan för att ha något att söka igenom.
        //Vi tar även emot key-word på det fruktnamn vi söker.
        //Om namnet inte finns med i listan returneras -1. Annars
        //returneras index på angiven frukt.
        //==========================================================
        static int LinearSearch(List<Frukt> list, string key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
