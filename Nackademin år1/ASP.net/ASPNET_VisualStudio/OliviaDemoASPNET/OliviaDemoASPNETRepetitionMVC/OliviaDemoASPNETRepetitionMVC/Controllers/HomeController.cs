using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OliviaDemoASPNETRepetitionMVC.ViewModels;

namespace OliviaDemoASPNETRepetitionMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PersonViewModel model = new PersonViewModel();

            List<SelectListItem> personTypes = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text = "Standard User" },
                new SelectListItem{Value = "2", Text = "Admin"}
            };

            model.PersonTypes = personTypes;

            return View(model);
        }
    }
}