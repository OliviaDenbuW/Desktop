using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tentaUppg5
{
    public class Klubb
    {
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Ort { get; set; }
        public string WebbAdress { get; set; }
        public Medlem Ordförande { get; set; }
        public List<Medlem> MedlemmarLista { get; set; }

        List<Medlem> MedlemmarList = new List<Medlem>();

        public Klubb(string namn, string adress, string ort, string webbAdress, Medlem ordförande)
        {
            this.Namn = namn;
            this.Adress = adress;
            this.Ort = ort;
            this.WebbAdress = webbAdress;
            this.Ordförande = ordförande;
        }

        public void NyMedlem(Medlem nyMedlem)
        {
            nyMedlem = new Medlem();
            MedlemmarLista.Add(nyMedlem);
        }

        public int AntalMedlemmar()
        {
            int antalMedlemmar = 0;

            foreach (var medlem in MedlemmarList)
            {
                antalMedlemmar++;
            }

            return antalMedlemmar;
        }
    }
}
