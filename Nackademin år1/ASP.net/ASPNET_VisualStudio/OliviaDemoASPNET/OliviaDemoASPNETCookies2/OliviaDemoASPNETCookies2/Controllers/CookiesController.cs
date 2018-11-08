using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OliviaDemoASPNETCookies2.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}