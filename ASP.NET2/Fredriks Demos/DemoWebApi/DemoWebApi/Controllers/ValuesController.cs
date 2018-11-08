using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWebApi.Models;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        //Första get som inte har några inparametrar
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return GetProducts();
        }

        // GET api/values/5
        //Här har vi mappat upp att ett id skickas in
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {

            return  GetProducts().SingleOrDefault(p => p.ID == id) ;
        }

        //Metod med två inparametrar. Det styrs i urlen om du hamnar här
        // tex dinurl/api/values/värdepånamn/värdepåpris

        [HttpGet("{name}/{price}")]
        public ActionResult<List<Product>> Get(string name, int price)
        {

            return GetProducts().Where(p => p.Name.Contains(name) || p.Price == price).ToList();
        }


        private List<Product> GetProducts()
        {
            //Istället för detta kan vi lägga på en databas och hämta värden därifrån
            List<Product> products = new List<Product>()
            {
                new Product("Samsung Galaxy S8", 1, 5999),
                new Product("Samsung Galaxy S9", 2, 8999),
                new Product("Huawei 10", 3, 7999)

            };


            return products;

        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
