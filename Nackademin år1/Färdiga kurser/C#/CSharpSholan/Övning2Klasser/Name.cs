using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2Klasser
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CompleteName { get { return FirstName + " " + LastName; } }
    }
}
