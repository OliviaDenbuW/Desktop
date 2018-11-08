using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Nackowskis.Models;
using Microsoft.AspNetCore.Authorization;
using Nackowskis.Models.AccountViewModel;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;

namespace Nackowskis.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        //***************************************
        //              HELPER METHODS
        //***************************************
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
        //***************************************
        //         END HELPER METHODS
        //***************************************

        //***************************************
        //         REGISTER
        //***************************************
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel vm, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            //Skapa nya usern
            if (ModelState.IsValid)
            {
                //Skapar en ny user-insatans utav de inmatade värderna vi fått
                var newUser = new ApplicationUser { UserName = vm.Email, Email = vm.Email };

                //Är ett Identity resultat (Ena är succeded, och den andra olika typer av errors)
                var result = await _userManager.CreateAsync(newUser, vm.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password");

                    //Loggar in användaren
                    await _signInManager.SignInAsync(newUser, isPersistent: false);
                    _logger.LogInformation("User created a new account with password");

                    return RedirectToLocal(returnUrl);
                }
                //Om result inte blev succeeded så körs AddError med result
                AddErrors(result);
            }
            // Om det går såhär långt har ngt failat, visa forumläret igen
            return View(vm);
        }

        //***************************************
        //         LOGIN
        //***************************************
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            //Rensar den existing cookie för att försäkra om att göra en clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel vm, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                //???????????????????
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true

                //Verifierar att password och username matchar

                //??????????????????????????

                //It then issues the encrypted authentication cookie, which contains user’s claims.
                var result = await _signInManager.PasswordSignInAsync(
                                vm.Email, vm.Password, vm.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in");
                    return RedirectToLocal(returnUrl);
                }
                if (result.IsLockedOut)
                {
                    _logger.LogInformation("User account locked out");
                    return RedirectToLocal(nameof(Lockout));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt");
                    return View(vm);
                }
            }

            //Kommer vi såhär långt så har det failat, visa login-formuläret igen
            return View(vm);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        //Loggar ut och deletar dens cookies
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}