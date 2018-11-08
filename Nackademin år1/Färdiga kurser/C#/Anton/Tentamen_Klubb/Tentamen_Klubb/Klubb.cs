using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamen_Klubb
{
    public class Klubb
    {
        public string namn { get; set; }
        public string adress { get; set; }
        public string ort { get; set; }
        public string webbadress { get; set; }
        public Medlem ordförande { get; set; }

        public void SetOrdförande(Medlem ordförande)
        {
            this.ordförande = ordförande;
        }

        /*
        //private string namn;
        //private string adress;
        //private string ort;
        //private string webbadress;

        public void SetNamn(string namn)
        {
            this.namn = namn;
        }

        public string GetNamn()
        {
            return namn;
        }*/
    }
}
