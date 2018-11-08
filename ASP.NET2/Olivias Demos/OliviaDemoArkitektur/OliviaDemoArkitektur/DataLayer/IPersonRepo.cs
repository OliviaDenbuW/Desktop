using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OliviaDemoArkitektur.Models;

namespace OliviaDemoArkitektur.DataLayer
{
    public interface IPersonRepo
    {
        Person GetPerson(int personId);
    }
}
