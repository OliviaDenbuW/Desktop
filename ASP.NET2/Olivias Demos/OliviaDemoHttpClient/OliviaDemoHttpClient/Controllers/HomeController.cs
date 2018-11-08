using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoHttpClient.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace OliviaDemoHttpClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Skapa upp instans av httpclient
            //snyggast o göra så
            using (HttpClient client = new HttpClient())
            {
                //1. sätta address
                //2 rader för..., jämf där nere
                client.BaseAddress = new Uri("http://demospo15webapi.azurewebsites.net");

                //Instans som tar emot svaret
                //i Getasync() skrivs resten av urln
                //Vi får ett response vi inte vill jobba i men det gör vi om till person.cs
                HttpResponseMessage response = client.GetAsync("/api/default").Result;

                //Skapa serialiser vi andvänder sen för serialisering
                //Det vi får tillbaka är en lista av personer
                //längst ut säger vi vad den ska representeras som och vi ser vad vi mappar till typeof(List<Person>)
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>));

                //LÄser in det i en stream för att sen kunna serialisera
                //3 rader för serialisering
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                List<Person> model = (List<Person>)serializer.ReadObject(responseStream);

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
