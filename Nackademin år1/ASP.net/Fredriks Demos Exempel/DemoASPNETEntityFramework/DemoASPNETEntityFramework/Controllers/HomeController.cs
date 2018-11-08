using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoASPNETEntityFramework.Models;

namespace DemoASPNETEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext _context;

        //Dependency injection via konstruktorn för att använda EF
        public HomeController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Använda contextklassen för att hämta data från databasen
            var model = _context.Person.ToList();

            //Skicka modellen till vyn
            return View(model);
        }
    }
}