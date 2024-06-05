using Secondhandshop1.Models;
using SecondHandShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHandShop1.Controllers
{
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Poruka = "Primjer 1 - poruka";
            return View();

        }

        public ActionResult Odgovor1()
        {

            ViewBag.Poruka = "Odgovor 1 - poruka";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ovo je naš webshop!";

            return View("O nama");
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Slobodno nas kontaktirajte:";

            return View();
        }

    }
}