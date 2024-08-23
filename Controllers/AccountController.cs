using SecondHandShop1.Models;
using System.Web.Mvc;

namespace SecondHandShop1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public ActionResult Login()
        {
            return View("LoginView");
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Implementacija prijave
                // Ovdje provjerite korisničko ime i lozinku
                // Na primjer, možete koristiti Identity Framework ili vlastitu logiku prijave

                // Nakon uspješne prijave, možete preusmjeriti korisnika na željenu stranicu
                return RedirectToAction("Index", "Dashboard");
            }

            // Ako je došlo do greške, prikažite formu za prijavu s greškama
            return View(model);
        }
    }
}
