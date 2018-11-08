using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoASPNETFormulärForts.ViewModels;
using DemoASPNETFormulärForts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoASPNETFormulärForts.Controllers
{
    public class MyPersonController : Controller
    {
        public IActionResult Create()
        {
            ViewModelPerson model = new ViewModelPerson();

            //Fyller på med värden för dropdownlistan och radiobuttons
            model.Countries.Add(new Country(1,"Sverige"));
            model.Countries.Add(new Country(2, "Danmark"));

            model.PersonTypes.Add(new SelectListItem { Text = "Pensionär", Value = "1" });
            model.PersonTypes.Add(new SelectListItem { Text = "Omyndig", Value = "2" });
            model.PersonTypes.Add(new SelectListItem { Text = "Myndig, ej pensionär", Value = "3" });

            //Skickar modellen till vyn
            return View(model);
        }


        //Tar empot svaret från formuläret i vyn.
        [HttpPost]
        public IActionResult Create(ViewModelPerson person)
        {
            return View();
        }
    }
}