using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRepitition1
{
    class Program
    {
        static void Main(string[] args)
        {  

            int antal;
            antal = 5;

            int tal1 = antal + 1 + (2 * 3) ;

            antal = tal1 - 2;

            antal = antal - 1;

            string namn = "Fredrik";

            //Explicit konvertering
            int temperatur1 = Convert.ToInt32(38.5);
            int temperatur2 = (int) 38.5;
            // int temperatur3 = int.Parse("38.5"); - Fungerar inte

           


            Console.Write("Variabel antal innehåller: ");
            Console.WriteLine(antal);

            double medlevärde1 = (2 + 2 + 3) / 3.0;
            double medelvärde2 = BeräknaMedelvärde(2, 2, 3);

            double s = 0;
            double m = 0;

            BeräknaSummaOchMedelvärde(2, 3, 3, ref s, ref m);
            BeräknaSummaOchMedelvärde(2, 3, 3, ref s, ref m);
            BeräknaSummaOchMedelvärde(2, 3, 3, ref s, ref m);
            BeräknaSummaOchMedelvärde(2, 3, 3, ref s, ref m);

            Console.WriteLine(medelvärde2);

        }

        static double BeräknaMedelvärde(double a, double b, double c)
        {
            double resultat = (a + b + c) / 3;
            return resultat;
        }

        static void BeräknaSummaOchMedelvärde(double a, double b, double c, ref double summa, ref double medel)
        {
            //Beräkna Summa
            summa = summa + a + b + c;
            //Beräkna Medlevärde
            medel = (a + b + c) / 3;
            //Returnera två svar???

        }

    }
}
