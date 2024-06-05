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
    public class NakitController : Controller
    {
        private BazaDbContext db = new BazaDbContext();

        // GET: Nakit
        public ActionResult Index()
        {
            return View(db.Nakit.ToList());
        }

        // GET: Nakit/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nakit nakit = db.Nakit.Find(id);
            if (nakit == null)
            {
                return HttpNotFound();
            }
            return View(nakit);
        }

        // GET: Nakit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nakit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdNakit,Novo,Materijal,Velicina,Boja,Spol,Cijena,Slika,VrstaNakita")] Nakit nakit)
        {
            if (ModelState.IsValid)
            {
                db.Nakit.Add(nakit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nakit);
        }

        // GET: Nakit/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nakit nakit = db.Nakit.Find(id);
            if (nakit == null)
            {
                return HttpNotFound();
            }
            return View(nakit);
        }

        // POST: Nakit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdNakit,Novo,Materijal,Velicina,Boja,Spol,Cijena,Slika,VrstaNakita")] Nakit nakit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nakit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nakit);
        }

        // GET: Nakit/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nakit nakit = db.Nakit.Find(id);
            if (nakit == null)
            {
                return HttpNotFound();
            }
            return View(nakit);
        }

        // POST: Nakit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nakit nakit = db.Nakit.Find(id);
            db.Nakit.Remove(nakit);
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
