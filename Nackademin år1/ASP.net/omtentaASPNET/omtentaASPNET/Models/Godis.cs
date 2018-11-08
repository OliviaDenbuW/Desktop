using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace omtentaASPNET.Models
{
    public class Godis
    {
        public Godis(int id, string namn)
        {
            this.ID = id;
            this.Namn = namn;
        }

        public int ID { get; set; }
        public string Namn { get; set; }
    }
}
