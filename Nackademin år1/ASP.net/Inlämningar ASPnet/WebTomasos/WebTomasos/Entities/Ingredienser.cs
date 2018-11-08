using System;
using System.Collections.Generic;

namespace WebTomasos.Entities
{
    public partial class Ingredienser
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public int? Matratt { get; set; }

        public Matratt MatrattNavigation { get; set; }
    }
}
