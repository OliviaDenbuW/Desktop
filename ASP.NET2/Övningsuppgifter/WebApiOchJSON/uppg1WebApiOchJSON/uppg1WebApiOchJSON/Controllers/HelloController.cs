using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Json;

namespace uppg1WebApiOchJSON.Controllers
{
    //Default route
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        //public ActionResult<string> Get()
        //{
        //    return GetText();
        //}
        
        public ActionResult<List<string>> Get()
        {
            return GetListOfStrings();
        }

        private List<string> GetListOfStrings()
        {
            List<string> list = new List<string>();
            
            list.Add("Olivia");
            list.Add("Maria");
            list.Add("Charbel");

            return list;
        }

        private string GetText()
        {
            string text = "Hello detta är text från ett webapi";

            return text;
        }
    }
}