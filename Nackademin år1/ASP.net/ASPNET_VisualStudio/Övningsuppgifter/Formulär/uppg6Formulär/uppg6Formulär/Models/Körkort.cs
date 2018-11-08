using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppg6Formulär.Models
{
    public class Körkort
    {
        public Körkort(int id, string status)
        {
            this.ID = id;
            this.Status = status;
        }

        public int ID { get; set; }
        public string Status { get; set; }
    }
}
