using DemoASPNETIdentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DemoASPNETIdentity.ModelsIdentity;
using System.Threading.Tasks;

namespace DemoASPNETIdentity.Controllers
{
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

        public IActionResult Register()
        {
            return View();
        }

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