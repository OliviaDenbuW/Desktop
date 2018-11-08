using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoASPNETValidering.Models;

namespace DemoASPNETValidering.Controllers
{
    public class PersonsController : Controller
    {
        //Startmetod som visar vyn
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Person person)
        {
            //Här körs servervalideringen
            if (ModelState.IsValid)
            {
                //Allt är OK. Sparar in databasen
            }
            else
            {
                //Inte OK.Skicka tillbaka till vyn
            }

            return View();
        }
    }


   
    
}