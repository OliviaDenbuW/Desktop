using DemoASPNETIdentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DemoASPNETIdentity.ModelsIdentity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace DemoASPNETIdentity.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        //Dependency Injection via konstruktorn
        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
       )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            ViewData["CartCount"] = 10;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(RegisterUser user)
        {
            //Kontrollerar om det är en giltig användare
            var result = await _signInManager.PasswordSignInAsync(user.Username, user.Password, false, false);

            //Om inloggningen är riktig skicka användaren till startsidan i Home
            //Är man inloggad skapas en säkerhetscookie som ligger i webbläsaren
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        
        }

        //Logga ut en användare
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUser user)
        {
            //Lägger över värdena från sidan i en ApplicationUser klass
            var userIdentity = new ApplicationUser { UserName = user.Username };

            //Skapar användaren i databasen
            var result = await _userManager.CreateAsync(userIdentity, user.Password);

            ////Om det går bra loggas användaren in
            if (result.Succeeded)
            {

                await _signInManager.SignInAsync(userIdentity, isPersistent: false);
            }

            return View();
        }
    }
}