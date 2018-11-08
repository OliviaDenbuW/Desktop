using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbok_Inlämning1_ADONET.Models
{
    class ContactModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string ZipCode { get; set; }

        public string PostalArea { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
