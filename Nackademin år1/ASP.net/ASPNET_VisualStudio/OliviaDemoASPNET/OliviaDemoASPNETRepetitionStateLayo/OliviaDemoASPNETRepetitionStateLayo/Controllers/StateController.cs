using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoASPNETRepetitionStateLayo.Models;
using Newtonsoft.Json;

namespace OliviaDemoASPNETRepetitionStateLayo.Controllers
{
    public class StateController : Controller
    {
        //Öppna vyn
        public IActionResult AddValue()
        {
            return View();
        }

        //Tar emot resultatet/svaret från formuläret i vyn och jobbar med sessionsvariabeln
        //[HttpPost]
        //public IActionResult AddValue(Person person)
        //{
        //    List<Person> myList;

        //    if(HttpContext.Session.GetString("PersonList") == null)
        //    {
        //        myList = new List<Person>();


        //    }
        //    else
        //    {
        //        var temp = HttpContext.Session.GetString("PersonList");
        //        myList = JsonConvert.DeserializeObject<List<Person>>(temp);
        //    }

        //    myList.Add(person);

        //    var serializedValue = JsonConvert.SerializeObject(myList);
        //    HttpContext.Session.SetString("PersonList", serializedValue);


        //    return RedirectToAction("AddValue");
        //}


        [HttpPost]
        public IActionResult AddValue(Person person)
        {
            List<Person> myList;
            

            if (Request.Cookies["PersonList"] == null)
            {
                myList = new List<Person>();
            

            }
            else
            {
                var temp = Request.Cookies["PersonList"];
                myList = JsonConvert.DeserializeObject<List<Person>>(temp);
            }

            myList.Add(person);

            var serializedValue = JsonConvert.SerializeObject(myList);

            Response.Cookies.Append("PersonList", serializedValue);


            return RedirectToAction("AddValue");
        }
    }
}