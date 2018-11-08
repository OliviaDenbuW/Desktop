using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using upp1HttpClient.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace upp1HttpClient.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //using System.Net.Http
            using (HttpClient client = new HttpClient())
            {
                //Basadress där api finns som har all info om Luke 
                client.BaseAddress = new System.Uri("https://swapi.co");

                //Skapa response som tar emot och kör det här
                HttpResponseMessage response = client.GetAsync("/api/people/Luke%Skywalker").Result;

                //Skapa serializer där vi talar om vad vi vill mappa till
                //using System.Runtime.Serialization.Json
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

                //Skapar stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //Sista steg: Omvandla till Person object
                Person model = (Person)serializer.ReadObject(responseStream);

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
