using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenganExtra.Bowling
{
    class Game
    {
        public Game()
        {
            GameSeries = new List<GameSerie>();
        }

        public void RegisterSerie(int serieNo, int player1Score, int player2Score)
        {
            GameSerie serie = new GameSerie();
            serie.Player1Score = player1Score;
            serie.Player2Score = player2Score;
            GameSeries.Add(serie);
        }

        public Member GetWinner()
        {
            //Kan bara få fram vinnare om man kört 3ggr
            if (GameSeries.Count() != 3) return null;
            int player1ScoreNum = 0;
            int player2ScoreNum = 0;

            //Loppar alla serier
            foreach (GameSerie serie in GameSeries)
            {
                //Sumemrar ihop bådas score från alla serier o i slutet if ...
                player1ScoreNum += serie.Player1Score;
                player2ScoreNum += serie.Player2Score;
            }

            if (player1ScoreNum > player2ScoreNum)
                return Player1;
            if (player2ScoreNum > player2ScoreNum)
                return Player2;

        }
        public DateTime TimeStamp { get; set; }
        public Member Player1 { get; set; }
        public Member Player2 { get; set; }
        //Varje game har en lista av serie
        //blir varieblenamnet mellan Game och GameSerie
        public List<GameSerie> GameSeries { get; set; }
    }
}
