using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta3
{
    class Bil
    {
        public string NAme { get; set; }
        public string Adress { get; set; }
        public string Postnummer { get; set; }
        public string Ort { get; set; }

        Bil(string name, string adress, string postnummer, string ort)
        {
            this.NAme = name;
            this.Adress = adress;
            this.Postnummer = postnummer;
            this.Ort = ort;
        }
    }
}
