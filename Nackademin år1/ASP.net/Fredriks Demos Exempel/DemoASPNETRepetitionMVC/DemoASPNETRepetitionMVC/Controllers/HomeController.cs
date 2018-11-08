using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoASPNETRepetitionMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoASPNETRepetitionMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PersonViewModel model = new PersonViewModel();

            List<SelectListItem> categories = new List<SelectListItem>()
            { new SelectListItem{Value="1", Text="Standard user"},
              new SelectListItem{Value="2", Text= "Admin user"},
              new SelectListItem{Value="3", Text="Premium user"}

            };

            model.Categories = categories;


            return View("Index2", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PersonViewModel person)
        {
            if(ModelState.IsValid)
            {

                //Spara i databas
            }

            return View("Index2");
        }
    }
}