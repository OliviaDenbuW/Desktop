using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoASPNETModels.Models
{
    public class Utbildning
    {
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string Stad { get; set; }
        public int Langd { get; set; }
    }
}
