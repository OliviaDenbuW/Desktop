using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Door
    {
        public  string name { get; set; }
        public bool open { get; set; }
        public string keyRecurement { get; set; }
        public string description { get; set; }
        public int [] mapCords { get; set; }

    }
}
