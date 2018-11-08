using System;
using System.Collections.Generic;

namespace DemoASPNETEntityFramework.Models
{
    //Klass som mappar mot en tabell i databasen
    public partial class Person
    {
        public string PersonName { get; set; }
        public int PersonId { get; set; }
    }
}
