using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppg1Models.Models
{
    public class NewsSubject
    {
        public NewsSubject(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
