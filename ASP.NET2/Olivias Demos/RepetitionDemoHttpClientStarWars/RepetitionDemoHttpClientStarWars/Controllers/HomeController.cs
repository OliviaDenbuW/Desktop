using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepetitionDemoHttpClientStarWars.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace RepetitionDemoHttpClientStarWars.Controllers
{
    public class HomeController : Controller
    {
        //Finns antingen serverkod eller klient, alltså javascriptkod
        //Ena WebAPI som läggs på webservern och andra sidan anropet
        //Igår hur vi gör från serverkod via httpClient och det är antal klassen med metoder för att skapa asnropet
        //och ta emot data o stoppa in i egna objekt. KÖrfe httpClient och vi skapade webapi
        //WebAPI: I dot.net core som att bygga MVC utan vy

        //Igår hade vi eget API men idag kör vi på StarWarsAPI och gör anrop mot det och ta emot data från
        //det. SKapa klass som tar emot data
        //Denna demo är fokus inte på webapi

        //SKicka ett anrop där vi väljer en spevciell person med id 1 och få fram det
        //Det vi gjorde igår fast med ett externt API med lite mer properties etc
        //Skicka ett anrop där vi väljer en speciell person med id 1
        public IActionResult Index()
        {
            //Skapar referens till using sys.net.http föär där i ligget httpclient
            using(HttpClient client = new HttpClient())
            {
                //Basadress till där apiet finns
                client.BaseAddress = new System.Uri("https://swapi.co");

                //Skapa response som tar emot och kör det här
                HttpResponseMessage response = client.GetAsync("/api/people/1").Result;

                //Json response (serialisering) och då har vi ett verktyg som heter JsonSharp
                //Vi tar färdig jsonkod från starwars och lägger in i verktyget som gör om till klasser
                //Skapar upp klassen som vi vill mappa till och sen styr vi i applikationen på va
                //vi vill ha
                //Förbereda den klassen för serialisering via 2st attribut

                //Skapa en serialiser
                //using runtime.seri.json
                //Vad är det vi skap mappa? Vi talar om vad det är vi vill mappa (people objektet)
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(People));

                //Sammanfattat av vad vi gjort
                //1. Vi har satt adressen
                //2. VI har skickat själva anropet
                //skapaty edn serialiser
                //men nu måste vi ta hand om svaret vi får och omvandla det till vad vi vill

                //3. Skapar en stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //4. SIsta steget är att opmvandla till people objekt
                //VI använder vår serialiser
                People model = (People)serializer.ReadObject(responseStream);

                //SAMMANFATTAT:
                //Sätter adress
                //skickar anropet
                //tar emot det i en response 
                //skapar en serialiser
                //Talar om hur vi vill mappa till people obj
                //Läser in det i en stream
                //anväder vår serialiser för att gära om det här till ett objekt, vår people
                //skickar med vår modell till vyn
                //Kan lägga ut värdena bara för att se vi får med dem

                //EFTER KÖRNING:
                //VI skickasr anrop
                //får tillbaka svaret
                //öppnar serialisern
                //Läser över det i en responsestream
                //lägger över det i vår... ?
                //Namnet och längd kom med
                //Skillnad är att vi genereta upp en modellklassvi får från svaret och att vi anväde ett externt api
                //Man kan gå in o välja vad vi vill ha med i svaret genom [datamember]

                return View(model);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
