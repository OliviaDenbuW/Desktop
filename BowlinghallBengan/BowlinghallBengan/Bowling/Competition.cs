using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Competition
    {
        public Competition()
        {
            PlayedGames = new List<Game>();
            Parcipitants = new List<Member>();
        }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Game> PlayedGames { get; set; }
        public List<Member> Parcipitants { get; set; }
        /*
         * METODER:
         *      (Strategy) 
         *      Vi bryter ut all kod för att få vinnaren : ICompetitionWinnerCalculation
         *              - GetWinnerOfCompetition()
         *              - GetWinnerOfTheYear()
         *      - RegisterParticipant()
         *      - CreateGame()
         * 
         * KONSTRUKTOR (initialisera listor) + PROPERTIES
         * 
         1. För tävlingar kan vi använda StrategyPattern som är bra för att beräkna algoritmer
                1.1 GetWinnerOfOneCompetition()

                      - EN TYP AV UTRÄKNING FÖR VINNARE
                        - BestMemberSoFar
                        - Loopa igenom alla medlemmar och se om man hittar en ny (jämför current med soFar)
                                - Hitta hur många vunna matcher

                1.2 GetWinnerOfTheYear()

        2. Minst 10 matcher för en medlem för att vara med i en tävling: Gör till global

        3
        */
    }
}
