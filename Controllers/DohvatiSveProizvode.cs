using Secondhandshop1.Models;
using SecondHandShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHandShop1.Controllers
{
    public class DohvatiSveProizvode: Controller
    {
        private BazaDbContext db = new BazaDbContext();
        public ActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Odjeca = db.Odjeca.ToList(),  
                Nakit = db.Nakit.ToList(),
                Obuca = db.Obuca.ToList(),
          
            };

            return View(viewModel);
        }

    }
}