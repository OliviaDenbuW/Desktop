using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBankInlämning3
{
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string OrgNumber { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        //REGION
        public string PostOrt { get; set; }
        public string Stat { get; set; }

        public string PostalNumber { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
    }
}
