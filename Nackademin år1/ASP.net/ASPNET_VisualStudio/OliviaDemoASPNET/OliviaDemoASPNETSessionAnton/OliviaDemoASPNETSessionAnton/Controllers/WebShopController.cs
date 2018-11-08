using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OliviaDemoASPNETSessionAnton.Models;

namespace OliviaDemoASPNETSessionAnton.Controllers
{
    public class WebShopController : Controller
    {
        public IActionResult ViewProducts()
        {
            return View(GetData());
        }

        public IActionResult AddProduct(int id)
        {
            List<Product> productList;

            if (HttpContext.Session.GetString("Varukorg") == null)
            {
                productList = new List<Product>();
            }
            else
            {
                //Vi läser ut den sparade varukorgen
                var serializedValue = HttpContext.Session.GetString("Varukorg");

                //Gör om varukorgen till en lista
                productList = JsonConvert.DeserializeObject<List<Product>>(serializedValue);
            }

            //Kolla upp vilken produkt som har id:t
            productList.Add(GetData().SingleOrDefault(p => p.ID == id));

            //Updatera sessionsvariabeln. Spara productlist i sessionsvariabeln
            HttpContext.Session.SetString("Varukorg", JsonConvert.SerializeObject(productList));
            return RedirectToAction("ViewProducts");
        }

        public IActionResult Checkout()
        {
            List<Product> productList;

            if (HttpContext.Session.GetString("Varukorg") == null)
            {
                productList = new List<Product>();
            }
            else
            {
                //Vi läser ut den sparade varukorgen
                var serializedValue = HttpContext.Session.GetString("Varukorg");
                //Gör om varukorgen till en lista
                productList = JsonConvert.DeserializeObject<List<Product>>(serializedValue);
            }

            return View(productList);
        }

        public List<Product> GetData()
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Iphone 7", 7000),
                new Product(2, "Samsung 8", 9000),
                new Product(3, "Ihope 10", 10000)
            };

            return products;
        }
    }
}