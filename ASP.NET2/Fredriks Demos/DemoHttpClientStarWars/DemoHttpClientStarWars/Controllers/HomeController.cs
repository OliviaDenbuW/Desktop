using DemoHttpClientStarWars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace DemoHttpClientStarWars.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                //Basadress till web api:et
                client.BaseAddress = new System.Uri("https://swapi.co");

                //Skicka anropet och ta emot
                HttpResponseMessage response = client.GetAsync("/api/people/1").Result;

                //Skapa en serializer för att omvandla json till ett People objekt
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(People));

                //Läs över i en stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //Läs över till ett people objekt
                People model = (People)serializer.ReadObject(responseStream);

                return View(model);
            }

               
        }

        

       
    }
}
