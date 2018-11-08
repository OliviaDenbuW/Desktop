using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace demoOOP1.Model
{
    class Company
    {
        public static int antalFöretag;

        public string name;

        public Person manager;

        public string GetCompanyAndManagerName(/* Company this */)
        {
            // Tesla - Fredrik Haglund

           

            string result = this.name + " - " +
                            this.manager.givenName + " " +
                            this.manager.surname;

            return result;
        }

    }
}
