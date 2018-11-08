using System;
using System.Collections.Generic;

namespace omtentaASPNET.Models
{
    public partial class Person
    {
        public Person()
        {
            Lärare = new HashSet<Lärare>();
            Student = new HashSet<Student>();
        }

        public string Personnummer { get; set; }
        public string Namn { get; set; }

        public ICollection<Lärare> Lärare { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
