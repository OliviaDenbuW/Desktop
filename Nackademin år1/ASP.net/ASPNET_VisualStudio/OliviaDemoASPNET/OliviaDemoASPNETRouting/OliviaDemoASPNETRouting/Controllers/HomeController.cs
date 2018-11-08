using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OliviaDemoASPNETRouting.Controllers
{
    public class HomeController : Controller
    {
        [Route("Start")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}