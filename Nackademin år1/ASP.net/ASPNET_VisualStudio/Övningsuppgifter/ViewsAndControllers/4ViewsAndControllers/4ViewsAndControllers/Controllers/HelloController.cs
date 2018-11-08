using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _4ViewsAndControllers.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult UpdateDateTime()
        {
            DateTime today = DateTime.Now;
            ViewBag.Today = today;

            return View();
        }
    }
}