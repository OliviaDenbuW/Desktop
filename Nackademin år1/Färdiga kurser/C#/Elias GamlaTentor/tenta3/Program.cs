using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta3
{
    enum Årstid { Vinter, Vår, Sommar, Höst };

    class Program
    {
        static void Main(string[] args)
        {


            ////1.Ta bort alla dubletter i arrayen { 11,11,12,12,13,13,14,15,16}
            ////och skapa en ny array utan dubletter

            //int[] minArray ={ 11, 11, 12, 12, 13, 13, 14, 15, 16 };

            //int[] newArray = minArray.Distinct().ToArray();

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i]);
            //}


            ////2.Ta bort alla vokaler i strängen: "Flygande beckasiner söka whila på mjuka tufvor"(vokaler är: A, E,
            ////I, O, U, Y, Å, Ä och Ö och deras motsv i små bokstäver)

            //string strängen = "Flygande beckasiner söka whila på mjuka tufvor";
            //List<char> ngt = strängen.ToList();
            //string vokaler = "AEIUOYÅÄÖ";

            //foreach (var item in ngt.ToList())
            //{
            //    if (vokaler.Contains(item.ToString().ToUpper()))
            //    {
            //        ngt.Remove(item);
            //    }
            //}

            //string enSträng = "";
            //foreach (var item in ngt)
            //{
            //    enSträng += item.ToString();
            //}

            //Console.WriteLine(enSträng);



            //3.Avgör genom kod, om punkten p finns inom rectangeln r. Testa genom att sätta in värden på p och r

            //ehm va?


            ////4.Hur många tal mellan 1 - 1000 är jämt delbara med 17 ? Ange kod + antal

            //int count=0;
            //for (int i = 1; i < 1001; i++)
            //{
            //    if (i%17==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            ////5.Kolla att strängen s verkligen innehåller ett korrekt datum string s = "2011-03-18";

            //string s = "2011-03-18";

            //try
            //{
            //    DateTime strängen = DateTime.Parse(s);
            //    Console.WriteLine(strängen);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Ej korrekt datum");
            //}


            ////6.Du har en Enum: enum Årstid { Vinter, Vår, Sommar, Höst }.
            ////-A.Beräkna med kod vilket int värde Sommar har.
            ////-B.Sätt in intvärdet av Vår i Årstid och få dess enumvärde

            //int something = (int)(Årstid.Sommar);
            //Console.WriteLine(something);

            //int something2 = (int)(Årstid.Vår);
            //Console.WriteLine(something2);

            //Årstid minEnum = (Årstid)1;
            //Console.WriteLine(minEnum);



            //7.skriv en överlagrad konstruktor till klassen Bil som innehåller data:


            //8.Spara objektet var v = new
            //{
            //    Namn = "Kurt",
            //    Adress = "Bergsgatan 21",
            //    Postnummer = 11228,
            //    Ort = "Stockholm}, på en fil med namnet objekt.txt

            //var v = new
            //{
            //    Namn = "Kurt",
            //    Adress = "Bergsgatan 21",
            //    Postnummer = 11228,
            //    Ort = "Stockholm"
            //};

            //string path = @"C:\Users\elias\source\repos\GamlaTentor\BilTextFil.txt";
            //using (StreamWriter writer = new StreamWriter(path))
            //{
            //    writer.WriteLine(v.ToString());
            //}

            //9.Läs tillbaka till en anonym typ från filen i uppg 8


            //10.Rita en triangel i en panel där alla tre sidorna är lika långa(en liksidig triangel)


            int numberoflayer = 6, Space, Number;

            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++)  // Loop For Space
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value
                    Console.Write("|");
                for (Number = (i - 1); Number >= 1; Number--)  //decrease the value
                    Console.Write("|");
                Console.WriteLine();

                Console.ReadLine();

            }
        }
    }
}