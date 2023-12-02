using _05_Models.Context;
using _05_Models.Entities;
using _05_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_Models.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        // GET: Home
        public ActionResult Index()
        {
            var model = db.Kullanicis.ToList();
            return View(model);
        }

        public ActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Kullanici k = new Kullanici();
                k.Email = model.Email;
                k.FirstName = model.FirstName;
                k.LastName = model.LastName;
                k.Password = model.Password;
                k.Phone = model.Phone;
                k.Address = model.Address;

                db.Kullanicis.Add(k);
                db.SaveChanges();
                TempData["result"] = "Kayıt Başarılı";
                TempData["user"] = k.FirstName + " " + k.LastName;
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
          
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var user = db.Kullanicis.Where(i => i.Email == email && i.Password == password).FirstOrDefault();

            if (user != null)
            {
                TempData["user"] = user.FirstName + " " + user.LastName;
                TempData["result"] = "Giriş Başarılı";
                return View("Index");
            }
            return View();
        }
    }
}