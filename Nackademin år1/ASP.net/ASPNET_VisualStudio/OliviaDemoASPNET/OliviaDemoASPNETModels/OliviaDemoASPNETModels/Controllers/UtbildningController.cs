using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETModels.Models;

namespace OliviaDemoASPNETModels.Controllers
{
    public class UtbildningController : Controller
    {
        public IActionResult ViewDetails()
        {
            //Skapa ett utbildningsobjekt
            Utbildning model = new Utbildning();

            //Lägg till värden till alla properties
            model.Namn = "Programutvecklare .NET";
            model.Stad = "Stockholm";
            model.Beskrivning = "Man lär sig programmera";
            model.Langd = 2;

            //Skickar med modellen till vyn
            return View(model);
        }

        public IActionResult ViewList()
        {
            List<Utbildning> model = new List<Utbildning>();

            Utbildning cSharp = new Utbildning();
            cSharp.Namn = "C#";
            cSharp.Beskrivning = "Utbildning där man får bred plattform";
            cSharp.Langd = 2;
            cSharp.Stad = "London";

            model.Add(cSharp);


            Utbildning java = new Utbildning();
            java.Namn = "Java";
            java.Beskrivning = "Mer specificerad programmering";
            java.Langd = 2;
            java.Stad = "Stockholm";

            model.Add(java);

            return View(model);
        }
    }
}