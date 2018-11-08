using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoArkitektur.Models;
using DemoArkitektur.DataLayer;

namespace DemoArkitektur.BusinessLayer
{
    public class PersonBusiness : IPersonBusiness
    {
        private IPersonRepo _repo;

        //Injecta repositoryt för att kunna anropa
        public PersonBusiness(IPersonRepo repo)
        {
            _repo = repo;
        }

        public Person GetPerson(int personId)
        {
            //Anropar repositoryt och returnerar svaret
            return _repo.GetPerson(personId);
        }
    }
}
