using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoArkitektur.Models;

namespace DemoArkitektur.DataLayer
{
    public class PersonRepo : IPersonRepo
    {
        private DemoArkitekturContext _context;

        //Injecta context klassen för att kunna skapa anrop
        //mot databasen.
        //Datalayer är isolerat från controllern
        public PersonRepo(DemoArkitekturContext context)
        {
            _context = context;
        }

        public Person GetPerson(int personId)
        {
           //Anropa databasen och returnera svaret
           return _context.Person.SingleOrDefault(p => p.PersonId == personId);
        }
    }
}
