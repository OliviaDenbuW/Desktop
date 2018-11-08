using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using uppg1Formulär.Models;
using uppg1Formulär.ViewModels;

namespace uppg1Formulär.Controllers
{
    public class MyFormsController : Controller
    {
        public IActionResult Create()
        {
            ViewModelPerson model = new ViewModelPerson();

            List<SelectListItem> countries = new List<SelectListItem>
            {
                new SelectListItem{ Value="1", Text="Sweden" },
                new SelectListItem{ Value="2", Text="Finland" },
                new SelectListItem{ Value="3", Text="Norway" }
            };

            model.Countries = countries;

            List<SelectListItem> userTypes = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "Standard"},
                new SelectListItem{ Value = "2", Text = "Admin"},
                new SelectListItem{ Value = "3", Text = "Premium"}
            };

            model.UserTypes = userTypes;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ViewModelPerson user)
        {
            return View("RegisterConformation", user);
        }

        public IActionResult RegisterConformation()
        {
            return View();
        }

        public IActionResult SendQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendQuestion(Question question)
        {
            return View("ThankYou", question);
        }
    }
}