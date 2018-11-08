using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OliviaDemoArkitektur.Models;

namespace OliviaDemoArkitektur.DataLayer
{
    public class PersonRepo : IPersonRepo
    {
        //Det vi vill är att avnvävda vår contextklass för att prata med db
        private DemoArkitekturDbContext _context;

        public PersonRepo(DemoArkitekturDbContext context)
        {
            _context = context;
        }

        public Person GetPerson(int personId)
        {
            //Det vi tidigare skrev i controller
            return _context.Person.SingleOrDefault(p => p.Id == personId);
        }
    }
}
