using System;
using System.Collections.Generic;

namespace omtentaASPNET.Models
{
    public partial class Lärare
    {
        public int LärareId { get; set; }
        public string Personnummer { get; set; }

        public Person PersonnummerNavigation { get; set; }
    }
}
