using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uppg1Layout.Models;

namespace Uppg1Layout.Controllers
{
    public class HomeController : Controller
    {
        private NackademinContext _context;

        public HomeController(NackademinContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Utbildning.ToList();
            return View(model);
        }

        public IActionResult Start()
        {
            return View();
        }

        public IActionResult Utbildningar()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }
    }
}