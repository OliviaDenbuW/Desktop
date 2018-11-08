using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenganExtra.Bowling
{
    public class Competition
    {
        //När vi skapar vår competiton måste vi säga vilken startegy vi måste anvädna
        //Debug om ni inte har 10 matcher per person så sätt till ex lägre, ex 2
        int atLeastNumberOfGames = 10;

        //Hämta vinnare av täcling
        public Member GetWinner()
        {
            //Ska hitta den med bä
            Member bestSoFar = null;

            //LOppar igenom alla och gör float
            float bestSnittSoFar = 0;
            foreach (Member member in Parcipitants)
            {
                //VIll ta fram alla matcher som den här memebrs gjort
                //och sparar det som är bäst
                var gamesForPlayer = Games.Where(x =>)
                //antal
                int antalMatcher = gamesForPlayer.Count();
                int vunnaMatcher = Games.Where(x => x.GetWinner() == member).Count();
                double snitt = Convert.ToDouble(gamesForPlayer) / antalMatcher;

                //Om snitt är bättre än bestSnitt so far
                if (snitt > bestSnittSoFar)
                {
                    bestSoFar = member;
                    bestSnittSoFar = snitt;
                }
            }

            return bestSoFar;
        }
        //VI lägger in medlemmen bland all parti
        public RegisterParticipant(Member member)
        {
            Parcipitants.Add(member);

        }

        public Game CreateGame(Member member1, Member member2)
        {
            //kollar först om vi mötts
            bool alreadyPlayer = false;
            foreach (var game in Games)
            {
                if ((game.Player1 == member1 && game.Player2 == member2) ||
                    (game.Player2 == member1 && game.Player1 == member2))
                {
                    throw new Exception("Already have plauer");
                }
            }
            Games.Add(new Game );
            //FIxa kostnas
            //Added to AddedToGame(game)
        }

        public Competition()
        {
            Games = new List<Game>();
            Parcipitants = new List<Member>();
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public List<Game> Games { get; set; }
        public List<Member> Parcipitants { get; set; }
    }
}

//Vi har brytt ut all kod för att få vinnaren: GetWinnerför COmpetition så använder vi 
