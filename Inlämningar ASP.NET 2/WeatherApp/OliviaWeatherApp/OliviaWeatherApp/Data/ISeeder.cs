using OliviaWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaWeatherApp.Data
{
    interface ISeeder
    {
        Task CreateUserSeed();

        bool CheckIfSeedUserExists(ApplicationUser seedUser);

        Task CreateRoleSeed();

        Task CreateCitySeed();
    }
}
