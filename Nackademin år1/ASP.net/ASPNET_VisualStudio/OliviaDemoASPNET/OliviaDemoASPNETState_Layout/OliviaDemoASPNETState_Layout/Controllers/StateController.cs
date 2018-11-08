using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OliviaDemoASPNETState_Layout.Models;

namespace OliviaDemoASPNETState_Layout.Controllers
{
    public class StateController : Controller
    {
        public IActionResult AddPerson()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddPerson(Person person)
        //{
        //    List<Person> myList;

        //    if (HttpContext.Session.GetString("PersonList") == null)
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

        //    return RedirectToAction("AddPerson");
        //}

        [HttpPost]
        public IActionResult AddPerson(Person person)
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

            return RedirectToAction("AddPerson");
        }
    }
}