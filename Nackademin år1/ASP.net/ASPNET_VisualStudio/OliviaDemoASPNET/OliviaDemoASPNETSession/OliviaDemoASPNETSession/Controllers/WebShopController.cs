using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETSession.Models;

namespace OliviaDemoASPNETSession.Controllers
{
    public class WebShopController : Controller
    {
        public IActionResult ViewProducts()
        {
            //Öppnar beställningsvy
            return View(GetData());
        }


        public List<Product> GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Dator", 1, 6000),
                new Product("Telefon", 2, 3000),
                new Product("Laddare", 3, 400)
            };

            return products;
        }
    }
}