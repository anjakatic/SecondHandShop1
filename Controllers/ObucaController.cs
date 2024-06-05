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
    public class ObucaController : Controller
    {
        private BazaDbContext db = new BazaDbContext();

        // GET: Obuca
        public ActionResult Index()
        {
            return View(db.Obuca.ToList());
        }

        // GET: Obuca/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obuca obuca = db.Obuca.Find(id);
            if (obuca == null)
            {
                return HttpNotFound();
            }
            return View(obuca);
        }

        // GET: Obuca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Obuca/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdObuca,Novo,Materijal,Velicina,Boja,Spol,Cijena,Slika,VrstaObuce")] Obuca obuca)
        {
            if (ModelState.IsValid)
            {
                db.Obuca.Add(obuca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obuca);
        }

        // GET: Obuca/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obuca obuca = db.Obuca.Find(id);
            if (obuca == null)
            {
                return HttpNotFound();
            }
            return View(obuca);
        }

        // POST: Obuca/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdObuca,Novo,Materijal,Velicina,Boja,Spol,Cijena,Slika,VrstaObuce")] Obuca obuca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obuca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obuca);
        }

        // GET: Obuca/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obuca obuca = db.Obuca.Find(id);
            if (obuca == null)
            {
                return HttpNotFound();
            }
            return View(obuca);
        }

        // POST: Obuca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Obuca obuca = db.Obuca.Find(id);
            db.Obuca.Remove(obuca);
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
