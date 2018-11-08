using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nackowskis.BusinessLayer;
using Nackowskis.Models.AuctionViewModels;

namespace Nackowskis.Controllers
{
    public class AdminControllerTest : Controller
    {
        private readonly IAdminBusiness _businessLayer;

        public AdminControllerTest(IAdminBusiness businessLayer)
        {
            _businessLayer = businessLayer;
        }

        [Authorize (Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            return View();
        }
    }
}