using DemoASPNETRepetitionState_Layout.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DemoASPNETRepetitionState_Layout.Controllers
{
    public class StateController : Controller
    {
        public IActionResult AddValue()
        {
            return View("TEst");
        }

        //-----------------------------------------------------------------------------
        //** LÖSNING MED SESSION ******************************************************
        //-----------------------------------------------------------------------------

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


        //-----------------------------------------------------------------------------
        //** LÖSNING MED COOKIES ******************************************************
        //-----------------------------------------------------------------------------


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


            //Om man vill lagra cookien på disk skall detta skickas med vid append
            CookieOptions options = new CookieOptions();
            options.Expires = System.DateTime.Now.AddMonths(6);

            Response.Cookies.Append("PersonList", serializedValue);

            return RedirectToAction("AddValue");
        }
    }
}