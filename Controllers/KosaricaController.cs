using Secondhandshop1.Models;
using SecondHandShop1.Models;
using System.Linq;
using System.Web.Mvc;

namespace SecondHandShop1.Controllers
{
    public class KosaricaController : Controller
    {
        private BazaDbContext db = new BazaDbContext();

        // GET: Home/Index
        public ActionResult Index()
        {
            var currentUser = User.Identity.Name; 
          

            if (!string.IsNullOrEmpty(currentUser))
            {
                var korisnik = db.Korisnik.FirstOrDefault(k => k.KorisnickoIme == currentUser);
              
            }

            var odjeca = db.Odjeca.ToList();
            var nakit = db.Nakit.ToList();
            var obuca = db.Obuca.ToList();// Fetch all Odjeca items from the database

            // Prepare a view model with necessary data
            var viewModel = new IndexViewModel
            {
                Odjeca = odjeca,
                Nakit = nakit,
                Obuca = obuca
               
            };

            return View(viewModel); // Pass viewModel to the Index view
        }

        // Other actions...

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
