using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenganExtra.Bowling
{
    class Transaction
    {
        //Transaktion är av typen feeType
        public FeeType FeeType { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Amount { get; set; }
        public bool Payed { get; set; }
        public Game Game { get; set; }
        public Competition Competition { get; set; }
    }
}
