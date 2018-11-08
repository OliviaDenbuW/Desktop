using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riktig_omtenta_uppg4
{
    class Organization
    {
        public string Namn { get; set; }
        public string Gatuadress { get; set; }
        public string Ort { get; set; }
        public string Webbadress { get; set; }
        public Employee Manager { get; set; }

        public List<Employee> employees;

        public Organization(string namn, string gatuadress, string ort, string webbadress, Employee manager)
        {
            this.Namn = namn;
            this.Gatuadress = gatuadress;
            this.Ort = ort;
            this.Webbadress = webbadress;
            this.Manager = manager;
            this.employees = new List<Employee>();
        }

        public void AddEmployee(Employee nyAnställd)
        {
            employees.Add(nyAnställd);
        }

        public int NumberOfEmployees()
        {
            return employees.Count();
        }
    }
}
