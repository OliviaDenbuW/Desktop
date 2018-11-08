using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Uppg2Validering.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}