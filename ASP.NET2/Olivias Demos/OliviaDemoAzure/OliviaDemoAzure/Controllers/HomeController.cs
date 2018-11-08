using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoAzure.Models;

namespace OliviaDemoAzure.Controllers
{
    public class HomeController : Controller
    {
        private TestDBContext _context;

        //Dependency injection för att prata med db
        public HomeController(TestDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //LÄst ut alla studenter och lagt i lista med studenter
            List<Student> model = _context.Student.ToList();

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
