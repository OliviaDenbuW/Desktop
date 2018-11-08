using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppg6FormulärCV.Models
{
    public class Körkortsstatus
    {
        public Körkortsstatus(int id, string status)
        {
            this.ID = id;
            this.Status = status;
        }

        public int ID { get; set; }
        public string Status { get; set; }
        public bool IsChecked { get; set; }
    }
}
