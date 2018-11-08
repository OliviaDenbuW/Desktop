using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _2ViewsAndControllers.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult RandomNumber()
        {
            Random generator = new Random();
            int nr = generator.Next(1, 11);
            //int nr2 = generator.Next(1, 11);

            ViewBag.Value = nr;
            //ViewBag.Value2 = nr2;

            return View();
        }
    }
}