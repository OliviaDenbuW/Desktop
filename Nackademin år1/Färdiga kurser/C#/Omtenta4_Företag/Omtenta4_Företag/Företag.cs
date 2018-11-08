using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omtenta4_Företag
{
    class Företag
    {
        public string Name { get; set; }
        public string Gatuadress { get; set; }
        public string Ort { get; set; }
        public string WebbAdress { get; set; }
        public Person Ägare { get; set; }

        public List<Person> listAnställda = new List<Person>();
        public int antalAnställda = 0;
        

        public Företag(string namn, string ga, string ort, string webadress)
        {
            this.Name = namn;
            this.Gatuadress = ga;
            this.Ort = ort;
            this.WebbAdress = webadress;

            //this.listAnställda = new List<Person>();
        }

        public void NyAnställd(Person nyAnställd)
        {
            this.listAnställda.Add(nyAnställd);
            antalAnställda++;
        }

        public int AntalAnställda()
        {
            return antalAnställda;
        }
    }
}
