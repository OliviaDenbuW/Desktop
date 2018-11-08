using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uppg2FormulärModellEF.Models;

namespace uppg2FormulärModellEF.Controllers
{
    public class UserController : Controller
    {
        private LoginDBContext _context;

        public UserController(LoginDBContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserLogin user)
        {
            _context.UserLogin.Add(user);
            _context.SaveChanges();
            return View("Welcome", user);
        }

        public IActionResult ViewList()
        {
            var model = _context.UserLogin.ToList();

            return View(model);
        }

        public IActionResult UpdateUser(int id)
        {
            var model = _context.UserLogin.SingleOrDefault(user => user.UserId == id);

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateUser(UserLogin userUpdated)
        {
            var userOriginal = _context.UserLogin.SingleOrDefault(u => u.UserId == userUpdated.UserId);

            _context.Entry(userOriginal).CurrentValues.SetValues(userUpdated);
            _context.SaveChanges();

            return View();
        }

        public IActionResult DeleteUser(int id)
        {
            var user = _context.UserLogin.SingleOrDefault(u => u.UserId == id);

            _context.UserLogin.Remove(user);
            _context.SaveChanges();

            return View();
        }

       
        public IActionResult SearchForUser(string searchInput)
        {
            
            var searchResultDB = _context.UserLogin.Where(u => u.Name.Contains(searchInput)).ToList();

            return View(searchResultDB);
        }
    }
}