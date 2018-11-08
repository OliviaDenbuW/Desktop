using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uppg1WebApiOchJSON.Models;

namespace uppg1WebApiOchJSON.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public ActionResult<List<Person>> Get()
        {
            return GetPeople();
            //return GetOnePerson();
        }

        private Person GetOnePerson()
        {
            Person person = new Person("Bechuchi", "denbuw@gmail.com");

            return person;
        }

        private List<Person> GetPeople()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Ia", "anna-maria@hotmail.com"),
                new Person("Charbel", "charbel@gmail.com"),
                new Person("Felicia", "sebechu@hotmail.com")
            };

            return people;
        }
    }
}