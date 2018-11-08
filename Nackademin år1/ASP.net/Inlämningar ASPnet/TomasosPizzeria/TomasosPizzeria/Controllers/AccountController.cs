using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TomasosPizzeria.Models;

namespace TomasosPizzeria.Controllers
{
    public class AccountController : Controller
    {
        //Dependency injection
        private readonly TomasosContext _context;
        public AccountController(TomasosContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Kund user)
        {
            var existingUser = _context.Kund.FirstOrDefault(u => u.AnvandarNamn == user.AnvandarNamn && u.Losenord == user.Losenord);
            user = existingUser;

            if (existingUser != null && existingUser.Losenord == user.Losenord)
            {
                var serializedValue = JsonConvert.SerializeObject(existingUser);
                HttpContext.Session.SetString("User", serializedValue);
                HttpContext.Session.SetString("UserId", user.KundId.ToString());
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Felaktig användarnamn eller lösenord!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Kund kund)
        {
            if (ModelState.IsValid)
            {
                var newKund = new Kund();
                newKund.Namn = kund.Namn;
                newKund.Gatuadress = kund.Gatuadress;
                newKund.Postnr = kund.Postnr;
                newKund.Postort = kund.Postort;
                newKund.Telefon = kund.Telefon;
                newKund.Email = kund.Email;
                newKund.AnvandarNamn = kund.AnvandarNamn;
                newKund.Losenord = kund.Losenord;

                _context.Add(newKund);
                _context.SaveChanges();

                return View("Registered", newKund);
            }
            return View();
        }

        public IActionResult EditUserInfo()
        {
            var str = HttpContext.Session.GetString("User");
            Kund customer = JsonConvert.DeserializeObject<Kund>(str);
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUserInfo(Kund updatedUser)
        {
            if (ModelState.IsValid)
            {
                var changes = updatedUser;
                _context.Update(changes);
                var succeded = _context.SaveChanges();

                if (succeded > 0)
                {
                    var serializedValue = JsonConvert.SerializeObject(changes);
                    HttpContext.Session.SetString("User", serializedValue);

                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

    }
}