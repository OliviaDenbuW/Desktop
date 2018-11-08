using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _3ViewsAndControllers.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult ViewListData()
        {
            List<string> colors = new List<string>();
            colors.Add("Black");
            colors.Add("Red");
            colors.Add("White");
            colors.Add("Yellow");
            colors.Add("Green");

            ViewBag.Colors = colors;

            return View();
        }
    }
}