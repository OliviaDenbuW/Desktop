using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoHttpClient.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;


namespace DemoHttpClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                //Sätter grundadressen till där api:et ligger
                client.BaseAddress = new Uri("http://demospo15webapi.azurewebsites.net");

                //Skickar anropet till web api:et
                HttpResponseMessage response = client.GetAsync("/api/default").Result;

                //Skapar upp en klass för att kunna serialisera svaret. 
                //Kopplar den till en lista av Person klassen
                DataContractJsonSerializer serializer = 
                 new DataContractJsonSerializer(typeof(List<Person>));

                //Läser in svaret i en stream
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //Mappar streamen med en lista av Person klassen
                List<Person> model = (List<Person>)serializer.ReadObject(responseStream);

                //Skickar det vidare till vyn
                return View(model);
            }





               
        }

       
    }
}
