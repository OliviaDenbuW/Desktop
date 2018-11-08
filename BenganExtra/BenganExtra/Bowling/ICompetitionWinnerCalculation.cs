using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenganExtra.Bowling
{
    //Den ska kunna utifrån ett antal matcher kunna räkna ut en vinnare STRATEGY PATTERN en strategi för att räkna ut
    interface ICompetitionWinnerCalculation
    {
        Member GetWinner(List<Game> games)
    }

    //Vi jallar vår calkutlering BRawl
    //Vi programerar mot gränssniottet ICOmpetition och kan sen byta yt det
    public class BrawlCompetitionWinnerCalculation : ICompetitionWinnerCalculation
    {
        public Member GetWinner(List<Game> games)
        {
            Member bestSoFar = null;
            double bestSnittSoFar = 0;

            //HashSet: 
            //VI vill skapa en distintlista med alla members, vi har nu inte tillgång till participant, så vi vill skapa
            //en mptsvarighet och därför hashset = blir aldrig dubeltter (bröt ut från Competition och la in här)

            //från Competition är det som vi ska
            HashSet<Member> members;

            foreach (var game in games)
            {

            }
            games.Select(x => x.Player1).ToList();
            members.
        }
    }

}
