using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SecondHandShop1.Models;
using Secondhandshop1.Models;
using Org.BouncyCastle.Crypto.Digests;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace SecondHandShop1.Controllers
{
    public class KontaktController : Controller
    {

        private BazaDbContext db = new BazaDbContext();


        public ActionResult Index()
        {
            return View(db.Kontakt.ToList());
        }


        // GET: Korisnik/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View("Kontakt");
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
