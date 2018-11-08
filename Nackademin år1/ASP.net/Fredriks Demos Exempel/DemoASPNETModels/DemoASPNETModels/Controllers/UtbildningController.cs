using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoASPNETModels.Models;

namespace DemoASPNETModels.Controllers
{
    public class UtbildningController : Controller
    {

        // Metod för att visa detaljer om en utbildning
        //Anropas från ViewList vyn
        public IActionResult ViewDetails()
        {
            Utbildning model = new Utbildning();
            model.Namn = "Programutvecklare .NET";
            model.Beskrivning = "Programutvecklare .NET. Fördjupa dig i programmering genom ett av världens mest använda programmeringsspråk. Vill du få en kompetens som gör dig attraktiv på arbetsmarknaden och som kan ge dig en central position i ett framgångsrikt utvecklingsteam är Programutvecklare .NET en utbildning för dig!";
            model.Langd = 2;
            model.Stad = "Stockholm";

            //Skickar med modellen till vyn
            return View(model);
        }

        //Metod för att visa en vy med en lista på utbildningar
        public IActionResult ViewList()
        {
            List<Utbildning> model = new List<Utbildning>();
            Utbildning prog = new Utbildning();
            prog.Namn = "Programutvecklare .NET";
            prog.Beskrivning = "Programutvecklare .NET. Fördjupa dig i programmering genom ett av världens mest använda programmeringsspråk. Vill du få en kompetens som gör dig attraktiv på arbetsmarknaden och som kan ge dig en central position i ett framgångsrikt utvecklingsteam är Programutvecklare .NET en utbildning för dig!";
            prog.Langd = 2;
            prog.Stad = "Stockholm";

            model.Add(prog);

            Utbildning java = new Utbildning();
            java.Namn = "Programutvecklare Java";
            java.Beskrivning = "ava finns i allt från spel till säkerhetskritiska banksystem Programutvecklare Java. Vill du jobba med ett av världen mest använda programmeringsspråk? Är du en kreativ problemlösare? Ta chansen att jobba med Java! Du hittar det i allt från spel och appar i mobiltelefoner till stora säkerhetskritiska banksystem. En utbildning i Java-programmering är en bra investering för framtiden!";
            java.Langd = 2;
            java.Stad = "Stockholm";

            model.Add(java);

            //Skickar med modellen till vyn
            return View(model);
        }
    }
}