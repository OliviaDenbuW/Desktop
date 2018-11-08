using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OliviaDemoArkitektur.DataLayer;

namespace OliviaDemoArkitektur.BusinessLayer
{
    public class PersonBusiness : IPersonBusiness
    {
        //Injekta med using datalayer
        private IPersonRepo _repo;

        public PersonBusiness(IPersonRepo repo)
        {
            _repo = repo;
        }

        public Person GetPerson(int personId)
        {
            return _repo.GetPerson(personId);
        }
    }
}
