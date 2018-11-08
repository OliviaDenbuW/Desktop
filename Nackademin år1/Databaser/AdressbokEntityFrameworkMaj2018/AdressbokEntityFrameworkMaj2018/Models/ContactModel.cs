using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressbokEntityFrameworkMaj2018.Models
{
    class ContactModel
    {
        public int ContactID { get; set; }

        public string Name { get; set; }

        public string StreetName { get; set; }

        public string ZipCode { get; set; }

        public string PostalArea { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int ContactType { get; set; }
    }
}
