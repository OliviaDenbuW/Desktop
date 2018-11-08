using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETValidering.Models;

namespace OliviaDemoASPNETValidering.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}