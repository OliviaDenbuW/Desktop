using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OliviaDemoASPNETSession2.Models;

namespace OliviaDemoASPNETSession2.Controllers
{
    public class WebShopController : Controller
    {
        public IActionResult ViewProducts()
        {
            //Visar beställningsvyn
            return View(GetData());
        }

        public IActionResult AddProducts(int id)
        {

            List<Product> prodList;

            //Hämta produkten som objekt med hjälp av id (oftast från en db)
            Product product = GetData().SingleOrDefault(p => p.ID == id);

            //Om det är första gången finns ingen varukorg
            if(HttpContext.Session.GetString("Varukorg") == null)
            {
                prodList = new List<Product>();
            }
            else
            {
                var serializedValue = (HttpContext.Session.GetString("Varukorg"));
                prodList = JsonConvert.DeserializeObject<List<Product>>(serializedValue);
            }

            prodList.Add(product);

            //Lägga tillbaka listan i sessionsvariabeln
            var temp = JsonConvert.SerializeObject(prodList);
            HttpContext.Session.SetString("Varukorg", temp);

            return RedirectToAction("ViewProducts");
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public List<Product> GetData()
        {
            List<Product> productList = new List<Product>()
            {
                new Product(1, "Samsung Galaxy S8", 9000),
                new Product(2, "Iphone 7", 5500),
                new Product(3, "Samsung laddare", 350)
            };

            return productList;
        }
    }
}