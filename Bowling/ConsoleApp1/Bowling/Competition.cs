using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bowling
{
    public class Competition
    {
        //Strategy pattern
        //Replace in constructor
        public ICompetitionWinnerCalculation CompetitionWinnerCalculation { get; set; }

        public Member GetWinner()
        {
            return CompetitionWinnerCalculation.GetWinner(Games);
        }
        public void RegisterParticipant(Member member)
        {
            Participants.Add(member);
            member.AddedToCompetition(this);
        }

        public Game CreateGame(Member member1, Member member2)
        {
            foreach(var game in Games)
            {
                if((game.Player1 == member1 && game.Player2 == member2) ||
                    (game.Player2 == member1 && game.Player1 == member2))
                {
                    //Already played
                    throw new Exception("You have already playes against each other");
                }
            }
            var game2 = new Game
            {
                TimeStamp = DateTime.Now,
                Player1 = member1,
                Player2 = member2
            };
            Games.Add(game2);
            member1.AddedToGame(game2);
            member2.AddedToGame(game2);
            return game2;
        }

        public Competition()
        {
            Games = new List<Game>();
            Participants = new List<Member>();
            CompetitionWinnerCalculation = new BrawlCompetitionWinnerCalculation();
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public List<Game> Games { get; set; }
        public List<Member> Participants { get; set; }
    }
}
