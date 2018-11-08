using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omtenta4_Company
{
    class Company
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string Area { get; set; }
        public string WebAddress { get; set; }
        public Person Owner { get; set; }

        public List<Person> listOfEmployees = new List<Person>();

        public Company(string name, string steetAddress, string area, string webAddress, Person owner)
        {
            this.Name = name;
            this.StreetAddress = StreetAddress;
            this.Area = area;
            this.WebAddress = webAddress;
            this.Owner = owner;
        }

        public void NewEmployee(Person newEmployee)
        {
            listOfEmployees.Add(newEmployee);
        }

        public int NrOfEmployees()
        {
            return listOfEmployees.Count();
        }
    }
}
