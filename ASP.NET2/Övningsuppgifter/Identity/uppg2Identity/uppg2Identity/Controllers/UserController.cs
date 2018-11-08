using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using uppg2Identity.Models;
using uppg2Identity.Models.AccountViewModels;
using uppg2Identity.ViewModels;

namespace uppg2Identity.Controllers
{
    public class UserController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        //public async Task AddRoleToUser(LoginViewModel viewModel)
        //{
        //    if (!await _roleManager.RoleExistsAsync("Admin"))
        //    {
        //        var currentUser = await _userManager.FindByEmailAsync(viewModel.Email);

        //        var roleResult = await _roleManager.CreateAsync(new IdentityRole("Admin"));

        //        await _userManager.AddToRoleAsync(currentUser, "Admin");
        //    }           
        //}
    }
}