using _04_View_Controller_Data_Transfer.Context;
using _04_View_Controller_Data_Transfer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_View_Controller_Data_Transfer.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string name,string email,string password,string surname,string address, string phone)
        {
            Kullanici k = new Kullanici();
            k.Email = email;
            k.FirstName = name;
            k.LastName = surname;
            k.Password = password;
            k.Phone = phone;
            k.Address = address;

            db.Kullanicis.Add(k);
            db.SaveChanges();
            TempData["result"] = "Kayıt Başarılı";
            TempData["user"] = k.FirstName+" "+k.LastName;
            return View("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email,string password)
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
}Default