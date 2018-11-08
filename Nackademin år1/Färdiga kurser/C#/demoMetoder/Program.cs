using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoMetoder
{
    class GissaEttTal
    {
        public static int HämtaGissning(int antalGissningar)
        {
            while (true)
            {
                Console.WriteLine("Gissning " + antalGissningar + ": ");
                string text = Console.ReadLine();
                int tal;
                bool ärEttTal = int.TryParse(text, out tal);
                if (ärEttTal)
                {
                    return tal;
                }
                else
                {
                    Console.WriteLine("Du måste skriva ett tal med siffror. Försök igen!");
                }
            }
        }
    }

    class Program
    { // class-block starts
        static void Main(string[] args)
        {

            GreetSomeone(1, "Fredrik");
            GreetSomeone(3, "Klassen");

            var tal1 = 10; // tal1 blir en int då 10 är heltal litteral
            var tal2 = 10.0; // tal 2 blir en double;
            var tal3 = 10m;


            int talet = GissaEttTal.HämtaGissning(3);

            //Anropa - Invoke a method
            double a1 = GetRectangleArea(10.0, 20);

            Console.WriteLine("Ange bredd och höjd:");
            double bredd = double.Parse(Console.ReadLine());
            double höjd = double.Parse(Console.ReadLine());
            Console.WriteLine("Arean är " + GetRectangleArea(bredd, höjd));


        }


        static void GreetSomeone(int numberOfGreetings, string name)
        {
            // TODO: Här ska vi implementera metoden.

            for (int i = 0; i < numberOfGreetings; i++)
            {
                Console.WriteLine("Hello, " + name + "!");
            }
        }

        // Deklarera en metod
        // [<modifiers>] <return type> <method namn> ([<parameter declaration>, ...] ) 
        // { code block}
        // Signature for this method: ( double, double )
        static double GetRectangleArea(double rectangleWidth, double rectangleHeight)
        { // Implementation - Code Block for GetRectangleArea starts here
            double area = rectangleWidth * rectangleHeight;
            return area;
        } // Code Block for GetRectangleArea ends here

        // Olika signatur: (int, int)
        static int GetRectangleArea(int x, int y)
        {
            return 0;
        }

    } // class-block end
}
