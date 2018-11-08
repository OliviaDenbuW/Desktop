using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowskis.Data
{
    public interface ISeeder
    {
        Task Seed();
    }
}
