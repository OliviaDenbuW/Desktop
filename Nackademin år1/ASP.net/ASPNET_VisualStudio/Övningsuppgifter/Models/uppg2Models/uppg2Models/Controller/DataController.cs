using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace uppg2Models.Controller
{
    public class DataController : Controller
    {
        public IActionResult NewsDetails()
        {
            return View();
        }
    }
}