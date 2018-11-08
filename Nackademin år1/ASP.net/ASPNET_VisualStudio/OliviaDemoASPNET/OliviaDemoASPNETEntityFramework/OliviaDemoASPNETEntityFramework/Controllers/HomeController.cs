using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETEntityFramework.Models;

namespace OliviaDemoASPNETEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext _context;

        public HomeController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Person.ToList();
            
            return View(model);
        }
    }
}