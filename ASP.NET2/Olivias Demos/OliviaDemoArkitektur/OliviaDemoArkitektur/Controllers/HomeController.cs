using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoArkitektur.Models;
using OliviaDemoArkitektur.BusinessLayer;

namespace OliviaDemoArkitektur.Controllers
{
    public class HomeController : Controller
    {
        //Injektar interface för businnerss kontroller pratar med business inte datakälla
        private IPersonBusiness _bussinessLayer;

        //Injektion i konstruktor av bbusiness layer och då kan vi använda metod fårn business
        public HomeController(IPersonBusiness businessLayer)
        {
            _bussinessLayer = businessLayer;
        }

        public IActionResult Index()
        {
            //Värdet vi skickar in
            Person model = _bussinessLayer.GetPerson(1);
            return View();
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
