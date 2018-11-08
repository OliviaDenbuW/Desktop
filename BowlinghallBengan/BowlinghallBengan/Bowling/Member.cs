using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Member
    {
        public int MemberNr { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public DateTime StartDateMembership { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Competition> AttendedCompetitions { get; set; }

        public Member()
        {
            Transactions = new List<Transaction>();
            AttendedCompetitions = new List<Competition>();
        }

        public void AddMembership()
        {
            Transaction currentTransaction = new Transaction();
            currentTransaction.TimeStamp = DateTime.Now;
            currentTransaction.
        }

        //Ev IsMember

        /*
            METODER:
                - AddedToGame() - Vet inte var den används
                - AddedToCompetition() - Vet inte var den används
                - AddMembership() - När man är ny

            KONSTUKTOR + PROPERTIES

            1. AddedToCompetition()
                    - Lägg till den tävling som kommer in som inparameter till propertyn som är Competitions för membern
                    - Om en member blivit tillagd till en competition så ska man skapa en ny transaction instans:
                            - Fyll i alla prop som finns i Transaction.cs

               Extra:
                    //Skapa upp en competition och har då inga medlemmar
                    //Stefan ska anmälas och lägger då till honom till listan av participants som ligger i....
                    //This är den aktuella tävlingen (competition) och därför kan vi koppla
                    //AddedToCOmpetition() som sen lägga in i hans competitions
                    //Måste sen lägga till en transaktion till honom
                    //Sen har han två stycken så



            2. AddMembership()
                    - Man får inskickat dateFrom
                    - Ny transaktion skapas
                            - Fyll i alla prop på den instansen
                    - När den är klar lägger vi till den till currentMembers alla transaktioner (property)

                Extra:
                    //Vi vet att personen vill blir medlem, men vad är det för belopp? Jo det ligger i currentFee
                    //Skulle behöva ngt som håller i all currentFees, måste veta belopp och då måste vi hämta från currentFee (går inte med bara  trans)

                    //Ett kodProjekt: DesignPatterns
                    //PORBLEM: VAd kostar det att bli medlem nu??? Då kollar vi i singelton listan
                    //Måste ta reda poå vad det kostar just nu och då slår vi mot CurrantFeeList
         */


    }
}
