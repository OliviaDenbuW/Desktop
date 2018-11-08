using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _5ViewsAndControllers.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Question()
        {

            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}