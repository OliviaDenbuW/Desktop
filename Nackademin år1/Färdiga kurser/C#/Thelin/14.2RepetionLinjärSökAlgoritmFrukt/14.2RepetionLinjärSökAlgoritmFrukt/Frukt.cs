using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2RepetionLinjärSökAlgoritmFrukt
{
    //======================KLASS=======================
    //Frukt. Innehåller information om frukt
    //==================================================
    class Frukt
    {
        private string name;
        private string color;
        private double pricePerKg;

        //METOD: Konstruktor
        public Frukt(string name, string color, double pricePerKg)
        {
            this.name = name;
            this.color = color;
            this.pricePerKg = pricePerKg;
        }

        //Egenskap - Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double PricePerKg
        {
            get { return pricePerKg; }
            set { pricePerKg = value; }
        }
    }
}
