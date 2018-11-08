using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg2Formulär.Models;

namespace uppg2Formulär.Controllers
{
    public class MyFormsController : Controller
    {
        public IActionResult SendQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendQuestion(Question question)
        {
            return View("ThankYou", question);
        }

        public IActionResult LoadPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoadPage(Message message)
        {
            return View(message);
        }
    }
}