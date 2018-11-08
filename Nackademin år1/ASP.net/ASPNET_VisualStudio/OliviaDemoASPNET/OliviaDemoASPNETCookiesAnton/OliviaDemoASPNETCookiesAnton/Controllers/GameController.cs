using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OliviaDemoASPNETCookiesAnton.Controllers
{
    public class GameController : Controller
    {
        public class Model
        {
            public string HtmlResult { get; set; }
        }

        public IActionResult Play(int id)
        {
            //Läser ut vad den tidigare spelaren valt (om det är den första spelaren är det null)
            string value = Request.Cookies["Choice"];

            if (value == null || value.Equals(""))
            {
                CookieOptions options = new CookieOptions();
                options.HttpOnly = true;
                options.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Append("Choice", id.ToString(), options);
                return View();
            }
            else
            {
                string result = null;

                switch (value)
                {
                    case "0":
                        if(id == 0)
                        {
                            result = "Tied";
                        }
                        else if(id == 1)
                        {
                            result = "Cookie won";
                        }
                        else
                        {
                            result = "Player won";
                        }
                        break;

                    case "1":
                        if (id == 0)
                        {
                            result = "Player won";
                        }
                        else if (id == 1)
                        {
                            result = "Tied";
                        }
                        else
                        {
                            result = "Cookie won";
                        }
                        break;

                    case "2":
                        if (id == 0)
                        {
                            result = "Cookie won";
                        }
                        else if (id == 1)
                        {
                            result = "Player won";
                        }
                        else
                        {
                            result = "Tied";
                        }
                        break;
                }

                Model m = new Model()
                {
                    HtmlResult = result
                };

                //Rensa cookien för framtida spel
                Response.Cookies.Delete("Choice");

                return View("ResultPage", m);
            }
        }

        public IActionResult StartGame()
        {
            return View("Play");
        }

        public IActionResult PlayAgain()
        {
            return View("Play");
        }
    }
}