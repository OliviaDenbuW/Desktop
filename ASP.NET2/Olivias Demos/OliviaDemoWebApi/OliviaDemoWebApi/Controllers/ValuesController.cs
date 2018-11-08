using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OliviaDemoWebApi.Models;

namespace OliviaDemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return GetProducts();
        }

        // GET api/values/5
        //Gör ett urval
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return GetProducts().SingleOrDefault(p => p.Id == id);
        }

        [HttpGet("{name}/{price}")]
        public List<Product> Get(string name, int price)
        {
            return GetProducts().Where(p => p.Name.Contains(name) || p.Price == price).ToList();
        }

        private List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Samsung Galaxy S8", 1, 5099),
                new Product("Samsung Galaxy S9", 2, 8999),
                new Product("Huawei", 3, 7999)
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
