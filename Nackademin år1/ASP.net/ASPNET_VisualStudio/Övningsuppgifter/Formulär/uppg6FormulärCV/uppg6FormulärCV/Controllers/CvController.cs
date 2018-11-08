using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using uppg6FormulärCV.ViewModels;
using uppg6FormulärCV.Models;

namespace uppg6FormulärCV.Controllers
{
    public class CvController : Controller
    {
        public IActionResult SkapaFormulär()
        {
            PersonViewModel model = new PersonViewModel();

            //Dropdown list
            model.UtbildningsBeskrivningar = new List<SelectListItem>
            {
                new SelectListItem { Text = "Högskoleutbildning", Value = "Högskoleutbildning" },
                new SelectListItem { Text = "Gymnasial", Value = "Gymnasial" },
                new SelectListItem { Text = "Yrkeshögskola", Value = "Yrkeshögskola" }
            };

            //Listbox
            model.Hobbisar = new List<SelectListItem>
            {
                new SelectListItem { Text = "Fotboll och äta glass", Value = "Fotboll och äta glass" },
                new SelectListItem { Text = "Grilla och chillination", Value =  "Grilla och chillination" },
                new SelectListItem { Text = "Älska allt och alla", Value  = "Älska allt och alla" },
                new SelectListItem { Text = "Gosa och mysa med mina hjärtan", Value = "Gosa och mysa med mina hjärtan" }
            };

            //Radiobuttons
            model.Regioner.Add(new Region(1, "Kan arbeta inom Sverige"));
            model.Regioner.Add(new Region(2, "Kan arbeta inom EU"));
            model.Regioner.Add(new Region(3, "Endast arbete regionalt"));

            //Checkbox
            model.Körkortsstatusar.Add(new Körkortsstatus(1, "Har inte körkort"));
            model.Körkortsstatusar.Add(new Körkortsstatus(2, "Har körkort"));
            model.Körkortsstatusar.Add(new Körkortsstatus(3, "Har tillgång till bil"));

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SkapaFormulär(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                return View("Bekräftelse", person);
            }

            return View();
        }
    }
}