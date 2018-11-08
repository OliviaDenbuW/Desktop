using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoASPNETIdentity.Controllers
{
    //För att komma åt detta måste man vara inloggad som administrator
    [Authorize(Roles ="Administrator")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}