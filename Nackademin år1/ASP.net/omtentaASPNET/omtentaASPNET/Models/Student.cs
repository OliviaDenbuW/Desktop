using System;
using System.Collections.Generic;

namespace omtentaASPNET.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Slutbetyg { get; set; }
        public string Personnummer { get; set; }

        public Person PersonnummerNavigation { get; set; }
    }
}
