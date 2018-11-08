using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETAjax2.Models;

namespace OliviaDemoASPNETAjax2.Controllers
{
    public class WebshopController : Controller
    {
        public IActionResult ViewProducts()
        {
            return View(ProductList());
        }

        private List<Product> ProductList()
        {
            List<Product> allProducts = new List<Product>()
             {
             new Product {ID=1, Name="Iphone 6", Price=5995, Description="iPhone 6s kommer med en 4,7” Retina-skärm med HD-upplösning och 3D Touch. Den är gjord av aluminium i 7000-serien och starkare glas än tidigare. Den har en A9-processor med 64 bit arkitektur, som i en stationär dator, en iSight-kamera på 12 MP med Live Photos, Touch ID, snabbare 4G LTE och Wi-Fi1, lång batteritid2, iOS 9 och iCloud. Allt detta i en förstärkt unibody-design med övergångar som är så diskreta att de inte märks."},
             new Product {ID=2, Name="Samsung Galaxy", Price=4995, Description="Denna eleganta Samsung Galaxy A3 (2016) smartphone har en 4,7 tum stor Super AMOLED HD-skärm och 13-megapixel kamera som tar fantastiska foton och Full HD-videor. 4.7 Super AMOLED HD-skärm13-MP, Full HD-videor. Lång batteritid" },
             new Product {ID =3, Name="Huawei", Price=4995, Description="Superslimmad smartphone med 5 Full HD-skärm, quad core-processor,4G och dubbla kameror. 5 Full HD-skärm Android 4.4.2 KitKat 13-megapixelkamera"}
             };

            return allProducts;
        }

        public IActionResult ViewProductDetails(int id)
        {
            Product model = ProductList().SingleOrDefault(p => p.ID == id);

            return PartialView("_DetailsPartial", model);
        }
    }
}