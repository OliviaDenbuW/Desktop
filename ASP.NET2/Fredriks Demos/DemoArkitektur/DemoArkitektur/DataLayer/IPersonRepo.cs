using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoArkitektur.Models;

namespace DemoArkitektur.DataLayer
{
    public interface IPersonRepo
    {
        Person GetPerson(int personId);

    }
}
