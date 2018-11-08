

using System;
using demoOOP1.Model;

namespace demoOOP1
{
    static class Huvudmeny
    {


        public static void VisaMeny()
        {
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("0) Avsluta");
            Console.WriteLine("1) Dra ett dåligt skämt");
            Console.WriteLine("2) Skapa ett Person objekt");
            Console.WriteLine("3) Skapa en hund");
        }

        public static void FrågaOmAlternativ()
        {
            bool avsluta = false;
            
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        avsluta = true;
                        break;
                    case "1":
                        Console.WriteLine("Hur blir programmerare rika?");
                        Console.WriteLine("Genom arv!");
                        break;
                    case "2":
                        SkapaEttPersonObjekt();
                        break;
                    case "3":
                        SkapaEnHund();
                    default:
                        Console.WriteLine("Ogilitgt menyalternativ");
                        break;
                }
            } while (!avsluta);
        }

        private static void SkapaEnHund()
        {
            Dog d1 = new Dog();

            d1.givenName = "Lassie";
        }

        private static void SkapaEttPersonObjekt()
        {
            Person p1;
            Person p2;
            Person p3;
            
            p1 = new Person();
            p1.givenName = "Fredrik";
            p1.surname = "Haglund";
            p1.birthday = new DateTime(1972, 04, 08);

            p2 = new Person();
            p2.givenName = "Jens";
            p2.surname = "Hejneskog";

            p3 = p2;
            p3.givenName = "Emma";

            var p4 = new Person
            {
                givenName = "Anna-Maria",
                surname = "Nordström"
            };

            Company c1 = new Company();
            c1.name = "Bardot";
            c1.manager = p4;

            Console.WriteLine(c1.name);
            Console.WriteLine(c1.manager.givenName);

            Company.GetCompanyAndManagerName();

            string text = c1.GetCompanyAndManagerName();
            Console.WriteLine(text);

            Company c2 = new Company();
            c2.name = "Tesla";
            c2.manager = p1;

            Company.antalFöretag = 2;

            // c2.antalFöretag = 2; - Kompilerar inte!

        }
    }
}
