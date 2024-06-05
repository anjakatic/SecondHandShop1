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

namespace SecondHandShop1.Controllers
{
    public class OdjecaController : Controller
    {
        private BazaDbContext db = new BazaDbContext();

        // GET: Odjeca
        public ActionResult Index()
        {
            return View(db.Odjeca.ToList());
        }

        // GET: Odjeca/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odjeca odjeca = db.Odjeca.Find(id);
            if (odjeca == null)
            {
                return HttpNotFound();
            }
            return View(odjeca);
        }

        // GET: Odjeca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Odjeca/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdOdjece,Novo,Materijal,Velicina,Boja,Spol,Cijena,Slika,VrstaOdjece")] Odjeca odjeca)
        {
            if (ModelState.IsValid)
            {
                db.Odjeca.Add(odjeca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(odjeca);
        }

        // GET: Odjeca/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odjeca odjeca = db.Odjeca.Find(id);
            if (odjeca == null)
            {
                return HttpNotFound();
            }
            return View(odjeca);
        }

        // POST: Odjeca/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOdjece,Novo,Materijal,Velicina,Boja,Spol,Cijena,Slika,VrstaOdjece")] Odjeca odjeca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odjeca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(odjeca);
        }

        // GET: Odjeca/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odjeca odjeca = db.Odjeca.Find(id);
            if (odjeca == null)
            {
                return HttpNotFound();
            }
            return View(odjeca);
        }

        // POST: Odjeca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Odjeca odjeca = db.Odjeca.Find(id);
            db.Odjeca.Remove(odjeca);
            db.SaveChanges();
            return RedirectToAction("Index");
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
