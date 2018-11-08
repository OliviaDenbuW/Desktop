using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg1Models.Models;

namespace uppg1Models.Controllers
{
    public class DataController : Controller
    {
        public IActionResult NewsDetails()
        {
            News model = new News();
            model.HeadLine = "KÄRLEKEN HAR KOMMIT FRÅN FORNA TIDER";
            model.NewsText = "När man öppnar sig för det fria flödar energin in i den levande. Blabla här är fördjupningen";

            return View(model);
        }

        public IActionResult NewsList()
        {
            List<News> model = new List<News>();
            News n1 = new News();
            n1.HeadLine = "NYHET 1";
            n1.NewsText = "Här är text 1";

            model.Add(n1);

            News n2 = new News();
            n2.HeadLine = "NYHET 2";
            n2.NewsText = "Här är text 2";

            model.Add(n2);

            return View(model);
        }

        public IActionResult Create()
        {
            List<NewsSubject> modelSubject = new List<NewsSubject>();
            modelSubject.Add(new NewsSubject(1, "Food"));
            modelSubject.Add(new NewsSubject(2, "Sports"));
            modelSubject.Add(new NewsSubject(3, "Traveling"));
            modelSubject.Add(new NewsSubject(4, "Health"));

            return View(modelSubject);
        }
    }
}