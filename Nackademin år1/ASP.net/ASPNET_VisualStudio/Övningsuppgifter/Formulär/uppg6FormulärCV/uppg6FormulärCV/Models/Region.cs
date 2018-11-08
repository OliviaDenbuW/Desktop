using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppg6FormulärCV.Models
{
    public class Region
    {
        public Region(int id, string plats)
        {
            this.ID = id;
            this.Plats = plats;
        }

        public int ID { get; set; }
        public string Plats { get; set; }
    }
}
