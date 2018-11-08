using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2
{
    enum CardColorsinSwedish
    {
        Hjärter,
        Klöver,
        Spader,
        Ruter
    };

    class Program
    {
        static void PlusMinus(int a, int b, ref int summan, ref int skillnaden)
        {
            summan = a + b;
            skillnaden = a - b;
        }

        static void Main(string[] args)
        {
            ////Uppgift 1
            ////summera de udda talen i följande array:
            ////int[] array = { 3, 2, 4, 1, 7, 8, 11, };

            //int[] array = { 3, 2, 4, 1, 7, 8, 11};
            //int sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 != 0)
            //    {
            //        sum += array[i];
            //    }
            //}
            //Console.WriteLine(sum);


            ////Uppgift 2.
            ////Sortera strängen i bokstavsordning.
            ////string namn =”Kurt”,”Oskar”,”Sven”,”Nils”;

            //string namn ="Kurt" + " " +  "Oskar" + " " + "Sven" + " " + "Nils";
            //string[] minaNamn = namn.Split(' ').ToArray();

            //Array.Sort(minaNamn);
            //foreach (var item in minaNamn)
            //{
            //    Console.WriteLine(item);
            //}

            //Uppgift 3.
            //Skapa en enum av färgerna i en kortlek.

            //check


            ////Fråga 4.
            ////Konvertera en sträng till en int och kolla att det är ett tal

            //string strängTal = "293857";
            //string inteSträngTal = "asfasf43";

            //try
            //{
            //    int minatal = Convert.ToInt32(strängTal);
            //    Console.WriteLine("Godkänt, resultat: \n" + minatal);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Inte tal");
            //}

            ////Fråga 5
            ////Ge exempel på en default konstruktor samt en överlagrad konstruktor för en class Bil

            //Bil mazda = new Bil("Mazda", 2015, 150000);

            //Bil Mercan = new Bil();
            //Mercan.Maker = "Mercedes";
            //Mercan.Year = 2020;
            //Mercan.Value = 10000000;



            ////Fråga 6
            ////Skapa en metod Plusminus som tar emot två tal samt
            ////returnerar både summan och skillnaden av talen.

            //int summan = 0;
            //int skillnaden = 0;
            //PlusMinus(900, 50, ref summan, ref skillnaden);
            //Console.WriteLine("Summan: " + summan);
            //Console.WriteLine("Skillnaden: " + skillnaden);

            ////Fråga7
            ////Skriv valideringskod för inmatning av datum(yyyymmdd) där år skall vara större än 2007 och månad
            ////skall vara mindre än maj och dag är ett korrekt dagnr

            Console.WriteLine("Date?");
            string input = Console.ReadLine();
            DateTime result;
            //DateTime.TryParse(input, out result);
            try
            {
                result = DateTime.ParseExact(input, "yyyymmdd", System.Globalization.CultureInfo.InvariantCulture);

                DateTime compar = new DateTime(2007, 05, 31);

                if (result.Year > compar.Year && result.Month < compar.Month)
                {
                    Console.WriteLine("Korrekt");
                }
                else
                {
                    Console.WriteLine("ngt blev fel");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Fyllde i datum ordentligt");
            }


            Console.ReadLine();
        }
    }
}
