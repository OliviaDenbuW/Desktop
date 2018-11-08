using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariaDemoASPNETSession.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MariaDemoASPNETSession.Controllers
{
    public class WebShopController : Controller
    {
        public IActionResult ViewProducts()
        {
            return View();
        }

        public IActionResult AddProduct(int id)
        {
            //Vi måste DEKLARERA en lista för att sedan kunna lägga in värden (produkterna man valt) i den. 
            //Listan är av datatypen Product (klasser kan också användas som datatyper)           
            List<Product> productList;

            //Fallet då det är FÖRSTA gången användaren väljer en produkt
            //"Varukorg" har inte blivit skapad sen innan, utan kommer att användas som referens senare
            if (HttpContext.Session.GetString("Varukorg") == null)
            {
                //Eftersom varukorgen/listan inte fanns sen innan (endast deklarerad från ovan), så måste den skapas
                productList = new List<Product>();
            }
            else
            {
                /*Man behöver ha det "serialiserade värdet" för att senare kunna refera till senare
                  Just nu är varukorgen fortfarande serialiserad och alla produkter är ihopklumpade. Man vill ha istället ha
                  dem separerade för att kunna behandla respektive produkt individuellt.
                */
                var serializedValue = HttpContext.Session.GetString("Varukorg");

                //Nu vill vi ha den serialiserade listan i separerad form och gör DEserialize och konveraterar
                productList = JsonConvert.DeserializeObject<List<Product>>(serializedValue);
            }

            /*Vi måste lägga till produkten i listan. Produkten vi "diskuterar"/vill lägga in är den
              som kommer via metodens inparametrar där uppe. Där uppe i denna metod, AddProduct, har vi en inparameter
              som är produktens id. Detta id kommer vi ha som jämförelse för att hitta den sökta produkten.
              Om vi skulle haft en databas, skulle vi istället fått som inparameter en HEL produkt av datatyp Product.
              Vi hårdkodade istället listan i GetData()
            */
            productList.Add(GetData().SingleOrDefault(p => p.ID == id));

            //Vi ska nu göra tillbaka den innan separerade listan till en hel. Vi Serialiserar  den igen
            HttpContext.Session.SetString("Varukorg", JsonConvert.SerializeObject(productList));
            return RedirectToAction("ViewProducts");
        }

        /*Den här metoden ska ENDAST skicka data (produkterna) till metoden ViewProducts. Via
          den här metoden ska inget komma "direkt" till skärmen för användaren. Metoden vidarebedrar
          bara data till en annan metod. Därför är den INTE en IActionResult-metod, utan bara List<Product>

          Product i List<Product> blir röd pga du inte än har importeraat namespace från Modelklassen
        */
        //public List<Product> GetData()
        //{
        //    //skapa Listan av produkter
        //    List<Product> listProducts = new List<Product>
        //    {
        //        new Product{1, "Iphone 8", 7000},
        //        new Product{2, "Samsung 9", 9000},
        //        new Product{3, "Iphone 10", 11000}
        //    };

        //    return listProducts;
        //}
    }
}