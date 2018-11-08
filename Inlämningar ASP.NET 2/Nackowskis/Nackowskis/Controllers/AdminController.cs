using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nackowskis.BusinessLayer;
using Nackowskis.Models.AuctionViewModels;

namespace Nackowskis.Controllers
{
    [Produces("application/json")]
    [Route("api/Admin")]
    public class AdminController : Controller
    {
        private readonly IAdminBusiness _businessLayer;

        public AdminController(IAdminBusiness businessLayer)
        {
            _businessLayer = businessLayer;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            _businessLayer.CreateAuction();
            return View();
        }

        [HttpPost]
        public void CreateAuction()
        {
            _businessLayer.CreateAuction();
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllAuctions()
        //{
        //    _businessLayer.GetAllAuctions();

        //    return View();
        //}

        //[HttpPut("{id}")]
        //public void UpdateAuction(int id)
        //{
        //    _businessLayer.UpdateAuction(id);
        //}

        //[HttpDelete("{id}")]
        //public void DeleteAuction(int id)
        //{
        //    _businessLayer.DeleteAuction(id);
        //}
    }
}