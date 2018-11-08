using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepetitionDemoHttpClient.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace RepetitionDemoHttpClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Här ska vi gära anropet till webapit
            //Vi har adressen till WebAPI www.exempel.com
            //Vi ska anropa det här webapiet ocvh få tillbaka data som vi serialiserar i 
            //ett personobjekt. VI skapar en egen klass med email, namn för mappningen

            //Skapa upp instans av httpclient
            using (HttpClient client = new HttpClient())
            {
                //1.
                //Sätter grundadress där api:et ligger
                client.BaseAddress = new Uri("http://demospo15webapi.azurewebsites.net");

                //2.
                //Skicka anropet till web api:et och skapa en responseMessage
                //Skickar anropet upp till den metoden vi vill komma åt i WebApiet, den heter default här
                //1. & 2. blir hela url:n som pekar på webapiet

                //VI får tillbaka rsponesen som vi inte vill jobba i
                HttpResponseMessage response = client.GetAsync("/api/default").Result;

                //1. = Basdelen av url
                //2. = själva API anropet
                //Detta räcker för anropet till API:et men vi vill inte ha det formatet
                //så vi skapar en klass som vi mappar till

                //Skapa klassen Person.cs
                //Lägg till attributen för serialisering
                //Using models (men finns redan)
                //3. using RUntime.Seri.Json
                //serialiseraren använder vi sen för att mappa och serialisera och det vi får  
                //tillbaka är en lista av Personer

                //FÖr att mappa - Vad ska serialisern rsultera i, jo en lista av personer, man talar
                //om vad den ska mappa till
                //EX tar emot ngt annat måste man tala om vad vi mappar till
                DataContractJsonSerializer serializer =
                    new DataContractJsonSerializer(typeof(List<Person>));

                //4.
                //Läser in svaret i en stream för att sen serialisera
                //3. 4. 5. Serialiseringen
                System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

                //5.
                //Mappar streamen med en lista av Person klassen
                List<Person> model = (List<Person>)serializer.ReadObject(responseStream);

                //skapat våram httpclient
                //satt vår address
                //skickat själva anropet till webapien, metyoden
                //skapat en serialiser för att kunna maååpa det här med våra egna obj
                //Läser in det här resultatet från anropet i en stream
                //Serialiseraren: mappar med vår påerson klass lista av objekt
                //får ut vår modell, listan av perszoner, som vi sen kan lägga ut på websidan
                //Vi returnerar modellen

                //razor för att få ut det o loopar igenom och skapar Namn o Email

                //SAMMANFATTNING
                //VI anropar ett webapi och får tillbaka data 
                //Trycker in datan i egna objekt med serialisering
                //Skickar iväg datan till vår vy och lägger sen ut det på webbsidan, listan av personer

                //Vi har skapat upp våran httpclient
                //VI har satt adressen
                //SKickar anropet
                //skapa upp vår serialiser
                //läser ut resultatt i vår stream
                //Mappar till vår egen personklass
                //I modellen har vi fått två personobjekt, från vår egen personklass
                //som vi skickar till websidan och får  ut där

                //Datan kommer från vårt webapi som vi har uppe på azure som vi hämtat och gjort om

                //man får tillbaka json och läser in det som en stream
                //Datat jag får från werbapiet är json
                
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
