using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _1ViewsAndControllers.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult ViewHello()
        {
            ViewBag.Message = "Hello MVC-Nu kör vi !!";

            return View();
        }
    }
}