using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubb
{
    public class Klubb
    {
        private string name;
        private string adress;
        private string ort;
        private string webb;
        private Medlem ordförande;
        private List<Medlem> listMedlemmar;

        public Klubb(string name, string adress, string ort, string webb)
        {
            this.name = name;
            this.adress = adress;
            this.ort = ort;
            this.webb = webb;
            this.listMedlemmar = new List<Medlem>();
        }

        public void SetOrdförande(Medlem person)
        {
            this.ordförande = person;
        }

        public void NyMedlem(Medlem medlem)
        {
            listMedlemmar.Add(medlem);
        }

        public int AntalMedlemmar()
        {
            return listMedlemmar.Count();
        }
    }
}
