using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Kap2_Uppg2_Person
{
    class Person
    {
        private string namn, adress;
        private int ålder;

        public Person(string namn, string adress, int ålder)
        {
            this.namn = namn;
            this.adress = adress;
            this.ålder = ålder;
        }

        // egenskaper
        public string Namn
        {
            get { return this.namn; }
        }

        public string Adress
        {
            get { return this.adress; }
            set { adress = value; }
        }

        public int Ålder
        {
            get { return this.ålder; }
        }

        public void FyllerÅr()
        {
            this.ålder++;
        }
    }
}
