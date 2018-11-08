using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TomasosPizzeria.Models;

namespace TomasosPizzeria.Controllers
{
    public class HomeController : Controller
    {
        private readonly TomasosContext _context;

        public HomeController(TomasosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}