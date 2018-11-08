using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bowling
{
    public class Member
    {
        public void AddedToGame(Game game)
        {
            Transaction transaction = new Transaction();
            transaction.Game = game;
            transaction.Timestamp = DateTime.Now;
            transaction.FeeType = FeeType.GameFee;
            transaction.Amount =
                CurrentFeeList.Instance.GetPriceForFeeType(FeeType.GameFee);
            Transactions.Add(transaction);

        }
        public void AddedToCompetition(Competition competition)
        {
            Competitions.Add(competition);

            Transaction transaction = new Transaction();
            transaction.Competition = competition;
            transaction.Timestamp = DateTime.Now;
            transaction.FeeType = FeeType.CompetitionFee;
            transaction.Amount =
                CurrentFeeList.Instance.GetPriceForFeeType(FeeType.CompetitionFee);
            Transactions.Add(transaction);

        }

        public Member()
        {
            Transactions = new List<Transaction>();
            Competitions = new List<Competition>();
        }

        public void AddMembership(DateTime dateFromWhen)
        {
            MemberFrom = dateFromWhen;

            Transaction transaction = new Transaction();
            transaction.Timestamp = DateTime.Now;
            transaction.FeeType = FeeType.MemberFee;
            transaction.Amount =
                CurrentFeeList.Instance.GetPriceForFeeType(FeeType.MemberFee);
            Transactions.Add(transaction);
        }

        public int MemberNo { get; set; }
        public string Name{ get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime MemberFrom { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}
