using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OliviaDemoASPNETIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string value = "Detta är information från controllern";

            //Skapa en behållare för att skicka data till vyn.
            //Senare används modeller för detta
            ViewBag.Value = value;
            
            //Skickar vidare till en vy med samma namn som denna metod
            //För att skicka vidare till en vy med annat namn skrivs View("NamnetPåAnnanVy");
            return View();
        }
    }
}