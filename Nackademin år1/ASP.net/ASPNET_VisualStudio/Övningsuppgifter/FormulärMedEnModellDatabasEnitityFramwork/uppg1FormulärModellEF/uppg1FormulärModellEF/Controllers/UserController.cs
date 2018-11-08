using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg1FormulärModellEF.Models;

namespace uppg1FormulärModellEF.Controllers
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
            //var model = _context.UserLogin.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var dbUser = _context.UserLogin.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                 if(dbUser == null)
                {
                    return View("Login");
                }
                 else
                {
                    ViewData["Name"] = dbUser.Name;

                    return View("Welcome");
                }
            }

            else
            {
                return View("ErrorPage");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserRegistration user)
        {
            if (ModelState.IsValid)
            {
                var dbUser = _context.UserLogin.SingleOrDefault(u => u.Email == user.Email);

                if (dbUser == null)
                {
                    _context.UserLogin.Add(new UserLogin { Name = user.Name, Email = user.Email, Password = user.Password, City = user.City });
                    _context.SaveChanges();

                    ViewData["Name"] = user.Name;

                    return View("Welcome");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        public IActionResult ViewList()
        {
            return View(_context.UserLogin.ToList());
        }

        public IActionResult Update(UserLogin user)
        {
            return View(user);
        }

    }
}