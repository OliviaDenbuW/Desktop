using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Punkt bowling blir allt från den mappen
namespace BenganExtra.Bowling
{
    class Member
    {
        public Member()
        {
            Transactions = new List<Transaction>();
            Competitions = new List<Competition>();

        }
        public int MemberNo { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime MemberFrom { get; set; }
        //Var blå på hans men tog bort
        public List<Transaction> Transactions { get; set; }
        //Det som den någonsin anmält sig till
        public List<Competition> Competitions { get; set; }

        public void AddedToGame(Game game)
        {
            Transaction transaction = new Transaction();
            //Vill peka ut vilket game eller vilken vompetition som vi betalar för
            transaction.Game;
        }

        //Syfte kostnas
        public void AddedToCompetition(Competition competition)
        {
            //Skapa upp en competition och har då inga medlemmar
            //STefan ska anmälas och lägger då till honom till listan av participants som ligger i....
            //This är den aktuella tävlingen (competition) och därför kan vi koppla
            //AddedToCOmpetition() som sen lägga in i hans competitions
            //Måste sen lägga till en transaktion till honom
            //Sen har han två stycken så
        }

        public void AddMembership(DateTime dateFromWhen)
        {
            MemberFrom = dateFromWhen;

            Transaction transaction = new Transaction();
            transaction.TimeStamp = DateTime.Now;
            transaction.FeeType = FeeType.MemberFee;
            //Vi vet att personen vill blir medlem, men vad är det för belopp? Jo det ligger i currentFee
            //Skulle behöva ngt som håller i all currentFees, måste veta belopp och då måste vi hämta från currentFee (går inte med bara  trans)

            //Ett kodProjekt: DesignPatterns
            //PORBLEM: VAd kostar det att bli medlem nu??? Då kollar vi i singelton listan
            //Måste ta reda poå vad det kostar just nu och då slår vi mot CurrantFeeList
            transaction.Amount =
                CurrentFeeList.Instance.GetPriceForFeeType(FeeType.MemberFee);
            //När vi gjort ovam, kan vi lägga in i memebersns lista av transaktioner
            //Lägger in i memebrnslista av transaktioner
            Transactions.Add(transaction);
        }

        
    }
}
