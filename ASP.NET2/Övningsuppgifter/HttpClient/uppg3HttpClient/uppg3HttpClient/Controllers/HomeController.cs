using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg3HttpClient.Models;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace uppg3HttpClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using(HttpClient client = new HttpClient())
            {
                //Basadress
                client.BaseAddress = new System.Uri("https://swapi.co");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new
                //    MediaTypeWithQualityHeaderValue("application/json"));

                //Skicka anropet och ta emot
                HttpResponseMessage response = client.GetAsync("/api/films/").Result;

                //Skapa serializer
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootObject));

                //Skapa stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //Omvandla till objekt Movie.cs
                RootObject model = (RootObject)serializer.ReadObject(responseStream);

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
