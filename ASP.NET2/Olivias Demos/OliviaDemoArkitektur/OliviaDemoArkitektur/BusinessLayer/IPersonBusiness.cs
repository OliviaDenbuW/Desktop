using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OliviaDemoArkitektur.Models;

namespace OliviaDemoArkitektur.BusinessLayer
{
    public interface IPersonBusiness
    {
        Person GetPerson(int personId);
    }
}
