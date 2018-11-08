using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenta_Uppg4_Uppg5_Klubb
{
    class Klubb
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }
        public string WebAddress { get; set; }
        public Medlem Ordförande { get; set; }

        public List<Medlem> ListOfMembers;
        //public List<Medlem> ListOfMembers { get; set; }
        //public int numberOfMembers = 0;

        public Klubb(string name, string address, string area, string web, Medlem ordförande)
        {
            this.Name = name;
            this.Address = address;
            this.Area = area;
            this.WebAddress = web;
            this.Ordförande = ordförande;
            this.ListOfMembers = new List<Medlem>();
        }

        public void NewMember(Medlem newMember)
        {
            this.ListOfMembers.Add(newMember);
            //numberOfMembers++;
        }

        public int NumberOfMembers()
        {
            //return numberOfMembers;
            return ListOfMembers.Count();
        }
    }
}
