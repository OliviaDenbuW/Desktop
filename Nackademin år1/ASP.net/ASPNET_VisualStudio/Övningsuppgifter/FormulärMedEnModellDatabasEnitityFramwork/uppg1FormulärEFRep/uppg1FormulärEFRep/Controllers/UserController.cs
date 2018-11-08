using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg1FormulärEFRep.Models;

namespace uppg1FormulärEFRep.Controllers
{
    public class UserController : Controller
    {
        private LoginDBContext _context;

        public UserController(LoginDBContext context)
        {
            _context = context;
        }
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryTokenAttribute]
        public IActionResult Login(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var dbUser = _context.UserLogin.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                //var dbUser = _context.UserLogin.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);

                if(dbUser != null)
                {
                    return View("Bekräftelse", user);
                }
                return View();
            }
            else
            {
                return View();
            }
            //var dbUser = _context.UserLogin.SingleOrDefault(u => (u.Email == user.Email) && (u.Password == user.Password));

            //if ((ModelState.IsValid) && (dbUser != null))
            //{
            //    return View("Bekräftelse", user);
            //}
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var dbUser = _context.UserLogin.SingleOrDefault(u => u.Email == user.Email);

                if(dbUser == null)
                {
                    _context.UserLogin.Add(new UserLogin { Name = user.Name, Email = user.Email, City = user.City, Password = user.Password });
                    _context.SaveChanges();

                    return View("Welcome");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View("ErrorPage");
            }
        }

        public IActionResult ViewList()
        {
            var model = _context.UserLogin.ToList();

            return View(model);
        }

        public IActionResult Update(int id)
        {
            var dbUser = _context.UserLogin.SingleOrDefault(u => u.UserId == id);

            return View(dbUser);
        }
    }
}