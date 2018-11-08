using Microsoft.AspNetCore.Identity;
using Nackowskis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowskis.Data
{
    public class Seeder : ISeeder
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public Seeder(UserManager<ApplicationUser> userManager,
                      RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Seeder(IServiceProvider serviceProvider)
        {
            _userManager = (UserManager<ApplicationUser>)serviceProvider.GetService(typeof(UserManager<ApplicationUser>));
            _roleManager = (RoleManager<IdentityRole>)serviceProvider.GetService(typeof(RoleManager<IdentityRole>));
        }

        public async Task Seed()
        {
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (await _userManager.FindByNameAsync("Admin") == null)
            {
                var user = new ApplicationUser { UserName = "Admin" };

                var result = await _userManager.CreateAsync(user, "Abc-123");

                if (!result.Succeeded)
                {
                    throw new ApplicationException("Couldn't create Admin");
                }
            }
        }
    }
}
