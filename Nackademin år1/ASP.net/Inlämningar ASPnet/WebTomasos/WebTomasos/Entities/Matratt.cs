using System;
using System.Collections.Generic;

namespace WebTomasos.Entities
{
    public partial class Matratt
    {
        public Matratt()
        {
            BestallningMatratt = new HashSet<BestallningMatratt>();
            Ingredienser = new HashSet<Ingredienser>();
            MatrattProdukt = new HashSet<MatrattProdukt>();
           // Produkter = new HashSet<Produkt>();
        }

        public int MatrattId { get; set; }
        public string MatrattNamn { get; set; }
        public string Beskrivning { get; set; }
        public int Pris { get; set; }
        public int MatrattTyp { get; set; }

        public MatrattTyp MatrattTypNavigation { get; set; }
        public ICollection<BestallningMatratt> BestallningMatratt { get; set; }
        public ICollection<Ingredienser> Ingredienser { get; set; }
       // public ICollection<Produkt> Produkter { get; set; }
        public ICollection<MatrattProdukt> MatrattProdukt { get; set; }
    }
}
