using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DemoASPNETFormulärForts.Models
{
    public class Person
    {
        [DisplayName("Ange namn")]
        public string Name { get; set; }

        [DisplayName("Ange land")]
        public int CountryID { get; set; }

        [DisplayName("Ange typ av person")]
        public int PersonTypeID { get; set; }
    }
}
