using Microsoft.AspNetCore.Identity;
using OliviaWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OliviaWeatherApp.Data
{
    public class Seeder : ISeeder
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public Seeder(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task CreateUserSeed()
        {
            //Skapa en uppsättning av användare --> Måste ha i UserManager
            var seedUser = new ApplicationUser
            {
                UserName = "Admin",
                Email = "admin@weathernow.com"
            };

            var userExists = CheckIfSeedUserExists(seedUser);

            if (userExists == false)
            {
                //Skapa fejtanvändaren
                var result = await _userManager.CreateAsync(seedUser, "Abc-123");

                if (!result.Succeeded)
                {
                    throw new ApplicationException("Couldn't create Admin");
                }
            }
        }

        public bool CheckIfSeedUserExists(ApplicationUser seedUser)
        {
            var user = _userManager.FindByNameAsync(seedUser.UserName);

            if (user == null)
            {
                return false;
            }

            return true;
        }

        public async Task CreateRoleSeed()
        {
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }
        }

        public Task CreateCitySeed()
        {
            throw new NotImplementedException();
        }

    }

}
