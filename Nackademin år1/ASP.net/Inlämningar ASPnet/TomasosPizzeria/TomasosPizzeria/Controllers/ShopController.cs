using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TomasosPizzeria.Models;
using TomasosPizzeria.ViewModels;

namespace TomasosPizzeria.Controllers
{
    public class ShopController : Controller
    {
        //Dependency injection
        private readonly TomasosContext _context;
        public ShopController(TomasosContext context)
        {
            _context = context;
        }


        public IActionResult Order()
        {
            if (HttpContext.Session.Get("User") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            //Maträtter
            List<OrderViewModels> menyLista = new List<OrderViewModels>();

            var m = _context.Matratt.ToList();

            foreach (var i in m)
            {
                OrderViewModels matratt = new OrderViewModels();
                List<Produkt> inLista = new List<Produkt>();
                matratt.Matratt = i;

                var mp = _context.MatrattProdukt.Where(z => z.MatrattId == i.MatrattId).Include(k => k.Produkt).ToList();

                foreach (var a in mp)
                {
                    var ing = new Produkt();
                    ing.ProduktId = a.ProduktId;
                    ing.ProduktNamn = a.Produkt.ProduktNamn;
                    inLista.Add(ing);
                }

                matratt.ProduktLista = inLista;
                menyLista.Add(matratt);
            }
            return View(menyLista);
        }

        public IActionResult Add(int id)
        {
            List<Matratt> matLista;

            Matratt matratt = _context.Matratt.SingleOrDefault(x => x.MatrattId == id);

            if (HttpContext.Session.GetString("Varukorg") == null)
            {
                matLista = new List<Matratt>();
            }
            else
            {
                var sessionValue = HttpContext.Session.GetString("Varukorg");
                matLista = JsonConvert.DeserializeObject<List<Matratt>>(sessionValue);
            }

            matLista.Add(matratt);
            var temp = JsonConvert.SerializeObject(matLista);
            HttpContext.Session.SetString("Varukorg", temp);

            return RedirectToAction("Order");
        }

        public IActionResult Checkout(List<Matratt> order)
        {
            var customer = int.Parse(HttpContext.Session.GetString("UserId"));

            if (HttpContext.Session.GetString("Varukorg") == null)
            {
                return RedirectToAction("Order");
            }

            var sessionValue = HttpContext.Session.GetString("Varukorg");
            List<Matratt> matLista = JsonConvert.DeserializeObject<List<Matratt>>(sessionValue);

            var best = new Bestallning()
            {
                Totalbelopp = matLista.Sum(x => x.Pris),
                BestallningDatum = DateTime.Now,
                Levererad = false,
                KundId = customer
            };

            _context.Bestallning.Add(best);

            var tempList = matLista.OrderBy(x => x.MatrattId);

            foreach (var item in tempList.Select(x => x.MatrattId).Distinct())
            {

                var b1 = new BestallningMatratt()
                {
                    BestallningId = best.BestallningId,
                    MatrattId = item,
                    Antal = matLista.Count(z => z.MatrattId == item)
                };

                _context.BestallningMatratt.Add(b1);
            }

            _context.SaveChanges();


            return View(matLista);


        }
    }
}