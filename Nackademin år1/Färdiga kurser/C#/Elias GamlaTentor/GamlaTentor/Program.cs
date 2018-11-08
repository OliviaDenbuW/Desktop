using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GamlaTentor
{
    class Program
    {
        //Skappa enum av årstider, UPPGIFT 1
        enum ÅrsTider { Sommar, Vinter, Vår, Höst }

        class Väder
        {
            public ÅrsTider årstid { get; set; }
            public string väder { get; set; }
        }

        public static string SortNumberString(string s)
        {
            char[] ngt = new char[s.Length];
            ngt = s.ToArray();
            int[] nya = new int[s.Length];
        
            for (int i = 0; i < ngt.Length; i++)
            {
                nya[i] = int.Parse(ngt[i].ToString());
            }

            int temp = 0;

            for (int i = 0; i < nya.Length; i++)
            {
                for (int j = 0; j < nya.Length - 1; j++)
                {
                    if (nya[j] > nya[j + 1])
                    {
                        temp = nya[j + 1];
                        nya[j + 1] = nya[j];
                        nya[j] = temp;
                    }
                }
            }

            StringBuilder strängen = new StringBuilder();
            for (int i = 0; i < nya.Length; i++)
            {
                strängen.Append(nya[i]);
            }

            return strängen.ToString();
        }

        static void Main(string[] args)
        {
            //////1.Skapa en enumeration av årsider

            ////Väder v = new Väder();
            ////v.väder = "Cold as hell";
            ////v.årstid = ÅrsTider.Vinter;

            ////Console.WriteLine(v.väder + v.årstid);
            ////Console.ReadLine();



            ////2 Sortera strängen "231596874" till strängen "123456789" med en egen sortfunktion

            //string w = "231596874";
            //string numbers = SortNumberString(w);
            //Console.WriteLine(numbers);
            //Console.ReadLine();



            ////3.Spara strängen i uppg. 2 i en textfil ”Tal.txt”

            //string path = @"C:\Users\elias\source\repos\GamlaTentor\Tal.txt";
            //using (StreamWriter Writer = new StreamWriter(path))
            //{
            //    Writer.WriteLine(numbers);
            //}


            ////4 Läs in strängen från filen i uppg3 och gör om den till en array av int
            //List<int> array = new List<int>();
            //string line = "";
            //int[] minInt = new int[9];

            //using (StreamReader reader = new StreamReader(path))
            //{
            //    while (true)
            //    {
            //        line = reader.ReadLine();

            //        if (line == null)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            for (int i = 0; i < line.Length; i++)
            //            {
            //                minInt[i] = Convert.ToInt32(line[i].ToString());
            //            }
            //        }
            //    }
            //}


            ////5.Skapa en klass som beskriver en Hund. Hunden har ett namn, en färg och en ägare.
            ////Ägaren skall komma från en klass Hundägare som ärver från klassen Person(Namn, adress, telefon)


            ////check se klasser.


            //6.Deklarera en array av klassen Hund samt lägg in 2 hundar i arrayen.

            Hund[] hundar = new Hund[2];

            Hundägare johan = new Hundägare();
            johan.Name = "Johan";
            johan.Adress = "Världsmedborgare";
            johan.Telefon = "070";

            Hundägare Dolph = new Hundägare();
            Dolph.Name = "Dolph";
            Dolph.Adress = "Världsmedborgare";
            Dolph.Telefon = "070";

            Hund hund1 = new Hund("puppy", "Black", johan);
            Hund hund2 = new Hund("ngt", "vit", Dolph);
            
            hundar[0] = hund1;
            hundar[1] = hund2;

            foreach (var item in hundar)
            {
                Console.WriteLine(item.Name + " " + item.Color + " " + item.Ägare.Name);
            }

            //7.Skapa en funktionalitet i klassen Hund där du kan ta reda på hur många hundar det finns
            //registrerade(instansierade) skriv kod för hur man får veta antal hundar.

            Hund.HowManyDogs();


            //8.Du har talen 265 - 290 Dra roten ur alla jämna tal och addera rötterna.Skriv ut summan
            int[] minaTal = new int[(290-265)];
            decimal sum = 0;

            for (int i = 265; i < 291; i++)
            {
                if (i%2==0)
                {
                    decimal evenNumber =  decimal.Parse(Math.Sqrt(i).ToString());
                    sum += evenNumber;
                }
            }
            Console.WriteLine(sum);




            Console.ReadLine();
        }
    }
}
