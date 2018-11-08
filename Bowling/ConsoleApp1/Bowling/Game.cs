using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bowling
{
    public class Game
    {
       public  void RegisterSerie(int serieNo, int player1Score, int player2Score)
        {
            GameSerie serie = new GameSerie();
            serie.Player1Score = player1Score;
            serie.Player2Score = player2Score;
            serie.SerieNo = serieNo;
            GameSeries.Add(serie);
        }
        public Member GetWinner()
        {
            if (GameSeries.Count() < 3) return null;
            int player1ScoreNum = 0;
            int player2ScoreNum = 0;
            foreach(GameSerie serie in GameSeries)
            {
                player1ScoreNum += serie.Player1Score;
                player2ScoreNum += serie.Player2Score;
            }
            if (player1ScoreNum > player2ScoreNum)
                return Player1;
            if (player1ScoreNum < player2ScoreNum)
                return Player2;
            return null;
        }
        public Game()
        {
            GameSeries = new List<GameSerie>();
        }
        public DateTime TimeStamp { get; set; }
        public Member Player1 { get; set; }
        public Member Player2 { get; set; }
        public List<GameSerie> GameSeries { get; set; }
    }
}
