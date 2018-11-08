using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta2
{
    public class Bil
    {
        public string Maker { get; set; }
        public int Year { get; set; }
        public decimal Value { get; set; }


        public Bil (string maker, int year, decimal value)
        {
            this.Maker = maker;
            this.Year = year;
            this.Value = value;
        }

        public Bil()
        {
        }
    }
}
