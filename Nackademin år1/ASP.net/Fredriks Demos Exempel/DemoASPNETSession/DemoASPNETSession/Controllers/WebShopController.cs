using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoASPNETSession.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace DemoASPNETSession.Controllers
{
    public class WebShopController : Controller
    {
        public IActionResult ViewProducts()
        {
            //Öppnar beställningsvyn
            return View(GetData());
        }

        public IActionResult AddProduct(int id)
        {
            List<Product> prodList;

            //Hämta produkten som objekt med hjälp av id (oftast från databasen) 
            Product product = GetData().SingleOrDefault(p => p.ID == id);
           

            //OM det är första gången finns ingen varukorg
            if(HttpContext.Session.GetString("Varukorg") == null)
            {
                prodList = new List<Product>();
            }
            else
            {
                //Om det redan finns en varukorg. Hämta listan från sessionsvariabeln
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
            //Hämta listan från sessiosvariabeln
            var serializedValue = (HttpContext.Session.GetString("Varukorg"));
            var model = JsonConvert.DeserializeObject<List<Product>>(serializedValue);

            return View(model);
        }

        public List<Product> GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Apple IPhone", 1, 10000),
                new Product("Samsun Galaxy", 2 , 9000),
                new Product("Huawei", 3, 8000)
            };


            return products;
        }
    }
}