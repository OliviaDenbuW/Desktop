using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBankInlämning3
{
    public class Bank
    {
        int nrOfCustomers;
        int nrOfAccounts;
        double totalBalanceOfBank = 0;

        List<Customer> customerList = new List<Customer>();
        List<Account> accountList = new List<Account>();

        public bool HuvudMeny()
        {

            Console.WriteLine("\nHuvudMeny");
            Console.WriteLine("0) Avsluta och spara");
            Console.WriteLine("1) Sök kund");
            Console.WriteLine("2) Visa kundbild");
            Console.WriteLine("3) Skapa kund");
            Console.WriteLine("4) Ta bort kund");
            Console.WriteLine("5) Skapa konto");
            Console.WriteLine("6) Ta bort konto");
            Console.WriteLine("7) Insättning");
            Console.WriteLine("8) Uttag");
            Console.WriteLine("9) Överföring");
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 0:
                        Console.WriteLine("Du har valt nummer 0");
                        return false;
                    case 1:
                        UtförSökning();
                        break;
                    case 2:
                        VisaKund();
                        break;
                    case 3:
                        SkapaKund();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Insättning();
                        break;
                    case 8:
                        Uttag();
                        break;
                    case 9:
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Du måste skriva siffran som motsvarar det menyval du vill göra.");

            }
            return true;
        }


        public void Textfil()
        {
            var filnamn1 = @"C:\Users\Helena\source\repos\Bank\bankdata-small.txt";
            var filnamn2 = @"C:\Users\Olivia\Desktop\Inlämning 3 - BANK\bankdata.txt";
            ImporteraTextfil(filnamn1, filnamn2);

        }

        public void ImporteraTextfil(string filnamn1, string filnamn2)
        {
            StreamReader textFil = new StreamReader(filnamn2);
            //Antalkunder är lika med siffran på första raden i textfilen.
            int antalKunder = int.Parse(textFil.ReadLine());
            //Loopar igenom alla kunder
            for (int i = 0; i < antalKunder; i++)
            {
                string kundRad = textFil.ReadLine();
                string[] delAvKundInfo = kundRad.Split(';');
                //Skapar en ny instans av kund
                Customer kund = new Customer();
                //Varje del som finns i textfilen lägger vi in i varsitt array-element.
                //Vi sparar värdena i kundens properties, för att komma åt dom utanför kodblocket.
                kund.CustomerNumber = int.Parse(delAvKundInfo[0]);
                kund.OrgNumber = delAvKundInfo[1];
                kund.CompanyName = delAvKundInfo[2];
                kund.Address = delAvKundInfo[3];
                kund.PostOrt = delAvKundInfo[4];
                kund.Stat = delAvKundInfo[5];
                kund.PostalNumber = delAvKundInfo[6];
                kund.Country = delAvKundInfo[7];
                kund.Telephone = delAvKundInfo[8];
                //Alla array-element lägger vi in i listan av kunder.
                customerList.Add(kund);

            }
            //När vi har loopat igenom alla kunder så symboliserar det på nästa rad, antal konton.
            int antalKonton = int.Parse(textFil.ReadLine());
            double totalSumma = 0;
            for (int i = 0; i < antalKonton; i++)
            {
                string kundRad = textFil.ReadLine();
                string[] delAvKundInfo = kundRad.Split(';');

                Account konto = new Account();
                konto.AccountNumber = int.Parse(delAvKundInfo[0]);
                konto.CustomerNumberOfAccount = int.Parse(delAvKundInfo[1]);
                konto.BalanceOfAccount = double.Parse(delAvKundInfo[2], CultureInfo.InvariantCulture);
                accountList.Add(konto);
                totalSumma += konto.BalanceOfAccount;
            }

            Console.WriteLine("Antal Kunder: {0} \nAntal Konton: {1}\nTotalsumma: {2}", antalKunder, antalKonton, totalSumma);

        }

        public void ExporteraFil(string filnamn1)
        {
            filnamn1 = DateTime.Now.ToString("") + ".txt";
            using (StreamWriter writer = new StreamWriter(filnamn1, true)) ;
        }

        public void SkapaKund()
        {
            Customer kund = new Customer();
            kund.CustomerNumber = NyttKundnummer();
            Console.Write("Organisationsnummer: ");
            kund.OrgNumber = Console.ReadLine();
            Console.Write("Namn: ");
            kund.CompanyName = Console.ReadLine();
            Console.Write("Gatuadress: ");
            kund.Address = Console.ReadLine();
            Console.Write("Stad: ");
            kund.City = Console.ReadLine();
            Console.Write("Postnummer: ");
            kund.PostalNumber = Console.ReadLine();
            Console.Write("Land: ");
            kund.Country = Console.ReadLine();
            Console.Write("Telefonnummer: ");
            kund.Telephone = Console.ReadLine();
            customerList.Add(kund);

            Account konto = new Account();
            konto.AccountNumber = NyttKontonummer();
            konto.BalanceOfAccount = 0;
            konto.CustomerNumberOfAccount = kund.CustomerNumber;
            accountList.Add(konto);
            Console.WriteLine("Grattis, du har skapat upp ett konto!");
            Console.WriteLine("Ditt kundnummer är : {0} \nDitt Kontonummer är: {1}", kund.CustomerNumber, konto.AccountNumber);

        }
        //Metod som tar fram ett nytt kundnummer
        public int NyttKundnummer()
        {
            //Jämför störst siffra med kundnumrerna. När vi har kommit till den största siffran så skickar vi
            //tillbaka störstSiffra+1, så får kunden ett kundnummer som är näst på tur.
            int störstSiffra = 0;
            foreach (var kund in customerList)
            {
                if (kund.CustomerNumber > störstSiffra)
                {
                    störstSiffra = kund.CustomerNumber;
                }
            }
            return störstSiffra + 1;
        }

        public int NyttKontonummer()
        {
            int störstSiffra = 0;
            foreach (var konto in accountList)
            {
                if (konto.AccountNumber > störstSiffra)
                {
                    störstSiffra = konto.AccountNumber;
                }
            }
            return störstSiffra + 1;
        }

        public void UtförSökning()
        {
            Console.WriteLine("*Sök kund*");
            Console.Write("Namn eller postort: ");
            string userInput = Console.ReadLine();
            var sökResultat = customerList.FindAll(kund => kund.CompanyName.Contains(userInput) || kund.PostOrt.Contains(userInput));

            foreach (var kund in sökResultat)
            {
                Console.WriteLine("{0} : {1}", kund.CustomerNumber, kund.CompanyName);
            }

        }

        public void VisaKund()
        {
            Console.WriteLine("*Visa Kundbild*");
            Console.Write("Kundnummer? ");
            string userInput = Console.ReadLine();
            var SökResultat = customerList.FindAll(kund => kund.CustomerNumber.ToString().Contains(userInput));

            foreach (var kund in SökResultat)
            {
                Console.WriteLine("Kundnummer: " + kund.CustomerNumber);
                Console.WriteLine("Organisationsnummer: " + kund.OrgNumber);
                Console.WriteLine("Namn: " + kund.CompanyName);
                Console.WriteLine("Adress: {0}, {1} {2}", kund.Address, kund.PostalNumber, kund.PostOrt);
                var sökKonton = accountList.FindAll(konto => konto.CustomerNumberOfAccount.ToString().Contains(kund.CustomerNumber.ToString()));
                Console.WriteLine("\nKonton: ");
                foreach (var konto in sökKonton)
                {
                    Console.WriteLine("{0} : {1} SEK", konto.AccountNumber.ToString(), konto.BalanceOfAccount);
                }
            }
        }

        public void Insättning()
        {
            Console.WriteLine("*Insättning*");
            Console.Write("Vilket konto vill du sätta in pengar på? ");
            string userInput = Console.ReadLine();
            var sökKonton = accountList.FindAll(konto => konto.AccountNumber.ToString().Contains(userInput));
            Console.Write("Hur mycket vill du sätta in? ");
            foreach (var konto in sökKonton)
            {
                double.TryParse(Console.ReadLine(), out double summaInsättning);
                konto.BalanceOfAccount += summaInsättning;
                Console.WriteLine("Din summa på konto {0} är nu {1} SEK", konto.AccountNumber, konto.BalanceOfAccount);
            }
        }

        public void Uttag()
        {
            Console.WriteLine("*Uttag*");
            Console.Write("Vilket konto vill du ta ut pengar från? ");

            string userInput = Console.ReadLine();
            var sökKonton = accountList.FindAll(konto => konto.AccountNumber.ToString().Contains(userInput));
            bool uttagKontroll = true;
            while (uttagKontroll)
            {
                Console.Write("Hur mycket vill du ta ut? ");

                foreach (var konto in sökKonton)
                {
                    double.TryParse(Console.ReadLine(), out double summaUttag);

                    konto.BalanceOfAccount -= summaUttag;
                    if (konto.BalanceOfAccount < 0)
                    {
                        Console.WriteLine("Du kan inte ta ut mer pengar än du har på kontot!!");
                        konto.BalanceOfAccount += summaUttag;
                    }
                    else
                    {
                        uttagKontroll = false;
                    }

                    Console.WriteLine("Din summa på konto {0} är {1} SEK", konto.AccountNumber, konto.BalanceOfAccount);
                }

            }
        }

    }
}
