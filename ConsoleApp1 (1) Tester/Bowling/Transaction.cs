using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bowling
{
    class Transaction
    {
        public FeeType FeeType { get; set; }
        public DateTime Timestamp { get; set; }
        public int Amount { get; set; }
        public bool Payed { get; set; }
        public Game Game { get; set; }
        public Competition Competition { get; set; }
    }
}
