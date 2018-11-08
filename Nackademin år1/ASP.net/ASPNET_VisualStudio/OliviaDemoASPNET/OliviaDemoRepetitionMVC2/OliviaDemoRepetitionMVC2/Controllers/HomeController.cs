using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OliviaDemoRepetitionMVC2.ViewModels;

namespace OliviaDemoRepetitionMVC2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PersonViewModel model = new PersonViewModel();

            List<SelectListItem> personTyper = new List<SelectListItem>()
            {
                new SelectListItem{Value = "1", Text = "Standard"},
                new SelectListItem{Value = "2", Text = "Premium"},
                new SelectListItem{Value = "3", Text = "Admin"}
            };

            model.PersonTyper = personTyper;

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(PersonViewModel person)
        {
            return View("Bekräftelse", person);
        }
    }
}