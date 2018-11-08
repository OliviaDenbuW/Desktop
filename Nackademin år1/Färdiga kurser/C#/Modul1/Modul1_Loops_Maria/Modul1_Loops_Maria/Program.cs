using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Loops_Maria
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE-loop: While loop använder man oändligt länge (om man inte aktivt väljer att stoppa den,
            //men exempelvis "break". 
            //Ex) Be användaren mata in x-antal nummer. Efter 1:a inmatade numret så ska en fråga ställas som
            //frågar om användaren vill avsluta programmet. Då ska man trycka "ENTER". Om användaren inte vill 
            //avsluta kommer man få mata in 2:a numret. Efter det så kommer samma fråga ställas om att avsluta.
            //Sedan fortsätter det såhär mot "oändligt antal inmatade nummer" om inte användaren väljer att avsluta
            //via ENTER.
            //ALLTSÅ: Så länge det är "sant/true" att användaren vill fortsätta mata in nummer så kommer ett
            //nytt tal kunna matas in.
            //För att "stoppa/break" förfrågningen om att mata in ett nytt nummer så kan man skriva "break"
            /*
            while (true)
            {
                Console.Write("Mata in ett nummer: (Eller 'ok' för att avsluta) ");
                string indata = Console.ReadLine();
                

                if (indata == "ok")
                {
                    break;
                }

                //om indatan INTE var "ok" så hoppar vi hit. DÅ sker omvandlingen från string till double
                double nummer = double.Parse(indata);
            }

            Console.WriteLine("Tryck enter för att avsluta");
            
    */
            //FOR-LOOP
            //Jämför mot while-loopen (som kan gå mot "oändligheten/OBESTÄMT antal gånger") med for-loopen
            //Om du vet att du vill att användaren ska mata in PRECIS FEM stycken tal så är 
            //det bra att använda for-loopen.
            //For-loopen är alltid bra att använda när det är BESTÄMT ANTAL VARV du vill göra någonting
            //Ovanför med while så fick användaren välja hur många ggr ett nummer skulle matas in.
            //Nu väljer du FEM stycken.
            //Ex)

            //#0 räknas som tal nummer 1, därför blir det MINDRE ÄN 5 nummer
            //Du hade också kunnat skriva:
            //(int i = 1; i <= 5; i++)
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Mata in ett nummer: ");
                string indataNummer = Console.ReadLine();
                double nummer = double.Parse(indataNummer);
            }

            Console.Write("Tryck enter för att avsluta");

        }
    }
}
