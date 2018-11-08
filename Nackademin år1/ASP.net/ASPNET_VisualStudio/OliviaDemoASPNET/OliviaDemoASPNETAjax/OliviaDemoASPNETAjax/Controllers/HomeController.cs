using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETAjax.Models;

namespace OliviaDemoASPNETAjax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ViewProducts()
        {
            return View();
        }

        public IActionResult ViewDetails(int id)
        {
            return PartialView(ProductList);
        }

        public IActionResult ViewDetails()
        {
            Product model = ProductList().Sing
            return View();
        }

       /* private List<Product> ProductList()
        {
            List<Product> allProducts = new List<Product>()
            {
                new Product {ID=1, Name="Iphone", Price=5600 };
            };

            return allProducts;
        }*/
    }
}