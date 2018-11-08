using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg4
{
    public class Klubb
    {
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Ort { get; set; }
        public string WebbAdress { get; set; }
        public Medlem Ordförande { get; set; }
    }
}
