using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using uppg6Formulär.Models;
using uppg6Formulär.ViewModels;

namespace uppg6Formulär.Controllers
{
    public class CvController : Controller
    {
        public IActionResult SkapaFormulär()
        {
            PersonViewModel model = new PersonViewModel();

            List<SelectListItem> utbildningsbeskrivningar = new List<SelectListItem>()
            {
                new SelectListItem { Value = "Högskola", Text = "Högskola" },
                new SelectListItem { Value = "Yrkesutbildning", Text = "Yrkesutbildning" },
                new SelectListItem { Value = "Gymnasial utbildning", Text = "Gymnasial utbildning"}
            };

            model.Utbildningsbeskrivningar = utbildningsbeskrivningar;

            List<Region> regioner = new List<Region>();
            regioner.Add(new Region(1, "Kan arbeta inom Sverige"));
            regioner.Add(new Region(2, "Kan arbeta inom EU"));
            regioner.Add(new Region(3, "Endast arbete regionalt"));

            model.Regioner = regioner;


            List<Körkort> körkortStatusar = new List<Körkort>();
            körkortStatusar.Add(new Körkort(1, "Har körtkort"));
            körkortStatusar.Add(new Körkort(2, "Har tillgång till bil"));
             
            model.KörkortStatusar = körkortStatusar;

            return View(model);
        }

        [HttpPost]
        public IActionResult SkapaFormulär(PersonViewModel person)
        {
            //var test = Request.Form["körtkortsstatus"];
            return View("Bekräftelse", person);
        }
    }
}