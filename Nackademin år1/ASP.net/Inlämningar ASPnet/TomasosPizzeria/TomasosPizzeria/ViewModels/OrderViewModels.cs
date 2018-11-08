using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomasosPizzeria.Models;

namespace TomasosPizzeria.ViewModels
{
    public class OrderViewModels
    {
        public Matratt Matratt { get; set; }
        public Produkt Ingredienser { get; set; }
        public BestallningMatratt BestallningMatratt { get; set; }
        public Bestallning Bestallning { get; set; }

        public List<Matratt> MatrattMeny { get; set; }
        public List<Produkt> ProduktLista { get; set; }
        public List<MatrattProdukt> Matkoppling { get; set; }
    }
}
