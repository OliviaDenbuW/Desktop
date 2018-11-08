using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using omtentaASPNET.Models;
using omtentaASPNET.ViewModels;

namespace omtentaASPNET.Controllers
{
    public class Uppgift1Controller : Controller
    {
        public IActionResult SkapaFormulär()
        {
            PersonViewModel model = new PersonViewModel();

            model.FavoritÅrstider = new List<SelectListItem>
            {
                new SelectListItem { Text = "(välj årstid)", Value = "(välj årstid)" },
                new SelectListItem { Text = "Sommar", Value = "Sommar" },
                new SelectListItem { Text = "Höst", Value = "Höst" },
                new SelectListItem { Text = "Vinter", Value = "Vinter" },
                new SelectListItem { Text = "Vår", Value = "Vår" }
            };

            
            model.FavoritGodisar.Add(new Godis(1, "Center"));
            model.FavoritGodisar.Add(new Godis(2, "Colaflaskor"));
            model.FavoritGodisar.Add(new Godis(3, "Plopp"));
            model.FavoritGodisar.Add(new Godis(4, "Gelehallon"));

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SkapaFormulär(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                return View("Tack", person);
            }

            return View();
        }
    }
}