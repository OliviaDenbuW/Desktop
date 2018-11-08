using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoASPNETFormulär.Models;

namespace DemoASPNETFormulär.Controllers
{
    public class UserController : Controller
    {
        //Metod som startar applikationen och visar login vyn
        public IActionResult Login()
        {
            return View();
        }

        //Metod som tar emot uppgifterna som matas in i login vyn och postas 
        //till webbservern
        [HttpPost]
        public IActionResult Login(UserInfo user)
        {
            //Testa att uppgiftera är riktiga innan det skickas vidare

            //Skicka uppgifter till en ny vy 
            return View("Welcome",user);
        }

    }
}