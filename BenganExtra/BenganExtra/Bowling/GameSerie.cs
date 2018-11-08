using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenganExtra.Bowling
{
    class GameSerie
    {
        //kommer vara 1 2 3
        public int SerieNo { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
    }
}
