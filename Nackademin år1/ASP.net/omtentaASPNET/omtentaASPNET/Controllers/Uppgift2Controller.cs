using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using omtentaASPNET.Models;
using omtentaASPNET.ViewModels;

namespace omtentaASPNET.Controllers
{
    public class Uppgift2Controller : Controller
    {
        private NorthwindContext _context;

        public Uppgift2Controller(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult VäljProdukt()
        {
            ProduktViewModel model = new ProduktViewModel();

            var produkterDB = _context.Products.ToList();

            model.Produkter = new List<SelectListItem>();

            for (int i = 0; i < produkterDB.Count; i++)
            {
                Products product = produkterDB[i];
                if (product.CategoryId == 1)
                {
                    model.Produkter.Add(new SelectListItem { Text = product.ProductName, Value = product.ProductId.ToString() });
                }
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VäljProdukt(ProduktViewModel produkt)
        {
            if (ModelState.IsValid)
            {
                List<Products> produktLista;

                if (produkt.Antal != 0 && produkt.Antal < 5)
                {
                    produktLista = new List<Products>();

                    for (int i = 0; i < produkt.Antal; i++)
                    {
                        var prodDB = _context.Products.SingleOrDefault(p => p.ProductId == produkt.ProduktIdn[0]);

                        produktLista.Add(prodDB);
                    }

                    return View("ValdaProdukter", produktLista);
                }

                var produktDB = _context.Products.SingleOrDefault(p => p.ProductId == produkt.ProduktIdn[0]);

                if (HttpContext.Session.GetString("ValdaProdukter") == null)
                {
                    produktLista = new List<Products>();
                }
                else
                {
                    var serializedValue = (HttpContext.Session.GetString("ValdaProdukter"));
                    produktLista = JsonConvert.DeserializeObject<List<Products>>(serializedValue);
                }

                if (produktLista.Count < 4)
                {
                    produktLista.Add(produktDB);

                    if (produktLista.Count == 4)
                    {
                        var temporär = JsonConvert.SerializeObject(produktLista);
                        HttpContext.Session.SetString("ValdaProdukter", temporär);

                        var serializedValue = (HttpContext.Session.GetString("ValdaProdukter"));
                        produktLista = JsonConvert.DeserializeObject<List<Products>>(serializedValue);

                        return View("ValdaProdukter", produktLista);
                    }
                }

                var temp = JsonConvert.SerializeObject(produktLista);
                HttpContext.Session.SetString("ValdaProdukter", temp);

                return RedirectToAction("VäljProdukt", produktLista);
            }            
            else
            {
                return View();
            }
        }
    }
}