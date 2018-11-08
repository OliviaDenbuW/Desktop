using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoASPNETRazor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Här skapas en lista som skall visas på websidan
            List<string> values = new List<string>();
            values.Add("Kalle");
            values.Add("Lisa");
            values.Add("Anna");
            values.Add("Pelle");

            
            ViewBag.Names = values;

            //Ytterligare en parameter som skickas till vyn
            ViewBag.State = 1;

            return View();
        }
    }
}