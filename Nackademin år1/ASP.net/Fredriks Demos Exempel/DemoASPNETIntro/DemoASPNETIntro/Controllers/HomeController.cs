using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoASPNETIntro.Controllers
{
    //Controller klass som ärver från basklassen. Måste ha 
    //controller med sist i namnet
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string value = "Detta är information från controllern";

            //Skapar en behållare för att skicka data till vyn
            //Ni kommer senare att använda modeller för detta
            ViewBag.Value = value;

            //Skickar vidare till en vy med samma namn som denna metod
            //För att styra till en annan vy skrivs View("NamnpåVyn");
            return View();
        }
    }
}