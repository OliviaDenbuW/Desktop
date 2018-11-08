using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2LinjärSökalgoritm
{
    //=====================KLASS=========================
    //Person. Innehåller infortmation om en person
    //===================================================
    class Person
    {
        private string name;
        private int personnummer;

        //METOD: Skapa konstruktor
        public Person (string name, int personnummer)
        {
            this.name = name;
            this.personnummer = personnummer;
        }

        //EGENSKAP - Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //EGENSKAP - Personnummer
        public int Personnummer
        {
            get { return personnummer; }
            set { personnummer = value; }
        }
    }
}
