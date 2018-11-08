using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg2HttpClient.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace uppg2HttpClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                //SKapa basadress till web apiet
                client.BaseAddress = new System.Uri("https://swapi.co");

                //Skicka anropet och ta emot det + resten av urln
                HttpResponseMessage response = client.GetAsync("/api/planets/1").Result;


                //Serialisering
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Planet));

                //Skapa stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //Mappa till objektet
                Planet model = (Planet)serializer.ReadObject(responseStream);

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
