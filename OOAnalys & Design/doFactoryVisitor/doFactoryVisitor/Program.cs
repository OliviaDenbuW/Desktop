using System;

namespace doFactoryVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup employee collection

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user

            Console.ReadKey();

            //Ta många av samma
            //Customers är objektstruktutten           
            //Attach på regular (attach lägger till i listanm)
            //VIsit (Address.Visit (hämtar adressen och skriver ut på samtliga)
            //Bowling:
            //Ta många av samma typ och göra ngt på alla samtidigt. 
            //Ex: MedlemsRegisterNytt år betala medlemsavgift (alla medlemmar måtse det ställas om för)
            //Man kan visa/ändra state för alla:
            //new YesarVIsitor (någon form av medlemsevent, klass), vet inte hur jag ska manipilera
            //manipulatorer. VIstorn är funktionen, besökaren som gör nåognting
            //COndotionVIstori: Om betalat efter npovember får du gratis
            //Manipulering eller extrahetring av infor från en känd kollektion
            //EX: Skicka till bankgiro, alla mina collections som har e-faktura och skriver ut EFakturaVisitorn
            //

        }
    }
}
