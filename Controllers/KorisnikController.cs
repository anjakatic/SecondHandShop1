using SecondHandShop1.Models;
using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using System.Data.Entity;
using Secondhandshop1.Models;
using System.Web.Security;

namespace SecondHandShop1.Controllers
{
    public class KorisnikController : Controller
    {
        private BazaDbContext db = new BazaDbContext();

        // GET: Korisnik/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // GET: Korisnik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Korisnik/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ime,Prezime,KorisnickoIme,Password")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    korisnik.Password = HashPassword(korisnik.Password);
                    db.Korisnik.Add(korisnik);
                    db.SaveChanges();
                    return RedirectToAction("Login", "Korisnik");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Pogreska kod kreiranja korisnika.");
                }
            }
            return View(korisnik);
        }

        // GET: Korisnik/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View("LoginView");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var korisnik = db.Korisnik.FirstOrDefault(k => k.KorisnickoIme == model.UserName);

                if (korisnik != null && VerifyPassword(model.Password, korisnik.Password))
                {
                    korisnik.IsLogged = true;  // Postavi IsLogged na true
                    db.Entry(korisnik).State = EntityState.Modified;
                    db.SaveChanges();

                    // Postavi autentifikacijski kolačić ako koristite FormsAuthentication
                    FormsAuthentication.SetAuthCookie(model.UserName, false);

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Pogrešno korisničko ime ili lozinka.");
            return View("LoginView", model);
        }

        public ActionResult Logout()
        {
            // Implementacija odjave
            var korisnik = db.Korisnik.FirstOrDefault(k => k.IsLogged);
            if (korisnik != null)
            {
                korisnik.IsLogged = false;
                db.Entry(korisnik).State = EntityState.Modified;
                db.SaveChanges();
            }

            // Ukloni autentifikacijski kolačić
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Korisnik");
        }

        // Metoda za provjeru lozinke
        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            using (var sha256 = SHA256.Create())
            {
                var hash = HashPassword(enteredPassword);
                return storedPasswordHash == hash;
            }
        }

        // Metoda za hashiranje lozinke
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
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
