using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg4HttpClient.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace uppg4HttpClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost("{name}")]
        [HttpPost]
        public IActionResult GetSearchResult(string search, string search2)
        {
            using (HttpClient client = new HttpClient())
            {
                //Skapa basadress
                client.BaseAddress = new System.Uri("https://swapi.co");

                //Fortsättning på url och skicka och ta emot anropet
                HttpResponseMessage response = client.GetAsync("/api/people?search=^" + search).Result;

                //Starta serialisering
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

                //Stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //Omvandling
                Person model = (Person)serializer.ReadObject(responseStream);

                return View(model);
            }
        }

        //[HttpPost("{name}")]
        //public IActionResult GetChosenPerson(string name)
        //{
            
        //}
        
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
