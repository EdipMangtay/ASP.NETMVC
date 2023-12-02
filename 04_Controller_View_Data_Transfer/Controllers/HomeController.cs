using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_Controller_View_Data_Transfer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string Ad = "ALTAN EMRE";

            //Data Transfer Yöntemleri:
            //  ViewBag,ViewData: Tek bir action boyunca data taşırlar.
            //  TempData : kullanılana kadar data taşır.

            ViewBag.Ad = Ad;
            ViewData["Soyad"] = "Demirci";
            TempData["Brans"] = "YAZILIM";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Contact2()
        {
            return View();
        }
    }
}