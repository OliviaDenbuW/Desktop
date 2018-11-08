using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoASPNETCookies.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult ViewCookies()
        {
            //Skapa inställnigar som styr cookien
            CookieOptions options = new CookieOptions();
            //options.HttpOnly = true;
            options.Expires = DateTime.Now.AddMonths(1);


            //Lägg till en cookie till responsen som skall skickas
            Response.Cookies.Append("Test", "Detta är texten i min cookie" , options);

            return View();
        }

        public IActionResult ReadCookies()
        {

            //Läs värdet från cookien som skickats från klienten
            string value = Request.Cookies["Test"];

            return RedirectToAction("ViewCookies");
        }
    }
}