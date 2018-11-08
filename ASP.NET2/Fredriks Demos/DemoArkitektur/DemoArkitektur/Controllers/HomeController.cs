using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoArkitektur.Models;
using DemoArkitektur.BusinessLayer;

namespace DemoArkitektur.Controllers
{
    public class HomeController : Controller
    {
        private IPersonBusiness _businessLayser;

        //Injecta business skiktet för att kunna göra anrop
        //Controllern är helt isolerad från datalayer 
        public HomeController(IPersonBusiness businesslayer)
        {
            _businessLayser = businesslayer;
        }

       

        public IActionResult Index()
        {
            //Anrop business skiktet för att hämta en person
            Person model = _businessLayser.GetPerson(1);

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
