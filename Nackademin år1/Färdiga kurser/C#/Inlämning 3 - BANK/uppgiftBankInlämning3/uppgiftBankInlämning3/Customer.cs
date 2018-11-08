using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgiftBankInlämning3
{
    public class Customer
    {
        private string orgNr;
        private string companyName;
        private string address;
        private string city;
        private string region;
        private int postNr;
        private string country;
        private int phone;

       /* public Customer(string orgNr, string companyName, string address, string city, string region, int postNr, string country, int phone)
        {
            this.orgNr = orgNr;
            this.companyName = companyName;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postNr = postNr;
            this.country = country;
            this.phone = phone;
        }

        public string OrgNr
        {
            get { return orgNr; }
            set { orgNr = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public int PostNr
        {
            get { return postNr; }
            set { postNr = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }*/

        public void CreateCustomer(string fileRow)
        {
            string[] dataAboutCustomer = fileRow.Split(';');
            
            foreach (string info in dataAboutCustomer)
            {
               Console.WriteLine(info);
            }
        }

        public static void AddCustomerToList(List<Customer> customerList)
        {
            customerList.Add(new Customer(/*orgNr, companyName, address, city, region, postNr, country, phone*/));
        }
    }
}
