using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OliviaWeatherApp.Models;
using OliviaWeatherApp.ViewModels;

namespace OliviaWeatherApp.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(SignInManager<ApplicationUser> signInManager,
                                UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var username = viewModel.Username;
                var password = viewModel.Password;

                var loginResult = await _signInManager.PasswordSignInAsync(username, password, false, false);

                if (loginResult.Succeeded)
                {
                    return View("Index", "Home");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();

            return View("Index", "Home");

        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                //Göra MODELL av den nya usern
                var newUser = MappingApplicationUserToRegisterViewModel(viewModel);

                //Skapa den nyregistrerade usern
                var result = await _userManager.CreateAsync(newUser, "Abc-123");

                if (result.Succeeded)
                {
                    //Logga in den nya användaren
                    await _signInManager.SignInAsync(newUser, false);

                    return RedirectToAction("Index", "Home");
                }
            }

            //Om det failade så skickas värderna med
            return View(viewModel);
        }

        private ApplicationUser MappingApplicationUserToRegisterViewModel(RegisterViewModel viewModel)
        {
            var user = new ApplicationUser
            {
                UserName = viewModel.Username,
                Email = viewModel.Email
            };

            return user;
        }

       
    }
}