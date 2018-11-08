using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OliviaDemoASPNETCookies.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult ViewCookies()
        {
            CookieOptions options = new CookieOptions();

            options.HttpOnly = true;
            options.Expires = DateTime.Now.AddMonths(1); //nu ej sessionscookie. Kommer sparas ner på disken o sparas 1 månad

            Response.Cookies.Append("Test", "Detta är texten på min cookie", options);

            return View();
        }

        public IActionResult ReadCookies()
        {
            string value = Request.
            return View();
        }
    }
}