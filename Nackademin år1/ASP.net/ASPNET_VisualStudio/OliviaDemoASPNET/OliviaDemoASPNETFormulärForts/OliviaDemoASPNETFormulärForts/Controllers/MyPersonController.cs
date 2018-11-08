using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETFormulärForts.ViewModels;
using OliviaDemoASPNETFormulärForts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OliviaDemoASPNETFormulärForts.Controllers
{
    public class MyPersonController : Controller
    {
        public IActionResult Create()
        {
            ViewModelPerson model = new ViewModelPerson();

            //Fyller på värden för dropdownListan och radioButtons
            model.Countries.Add(new Country(1, "Sverige"));
            model.Countries.Add(new Country(2, "Haiti"));
            model.Countries.Add(new Country(3, "Etiopien"));

            model.PersonTypes.Add(new SelectListItem { Text = "Pensionär", Value = "1" });
            model.PersonTypes.Add(new SelectListItem { Text = "Myndig, men ej pensionär", Value = "2" });
            model.PersonTypes.Add(new SelectListItem { Text = "Ej myndig", Value = "3" });

            return View(model);
        }
    }
}