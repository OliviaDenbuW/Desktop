using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoArkitektur.Models;

namespace DemoArkitektur.BusinessLayer
{
    public interface IPersonBusiness
    {
        Person GetPerson(int personId);

    }
}
