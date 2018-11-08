using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoHttpClientStarWars.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace OliviaDemoHttpClientStarWars.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                //Basaddress
                client.BaseAddress = new System.Uri("https://swapi.co");

                //Skapa respons som tar emot och kör det här
                HttpResponseMessage response = client.GetAsync("/api/people/1").Result;

                //Skapa serialisering
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(People));

                //Ta hand om svaret vi får och göra om till objekt people
                //Börja med skapa stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //Göra om till people objekt
                //Ta ut vårt objekt
                People model = (People)serializer.ReadObject(responseStream);

                //Skickar med vår model till vyn
                return View(model);
            }

               ;
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
