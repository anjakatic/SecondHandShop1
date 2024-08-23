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

namespace SecondHandShop1.Controllers
{
    public class NakitController : Controller
    {
        private BazaDbContext db = new BazaDbContext();


        // GET: Obuca
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                Nakit nakit = db.Nakit.Find(id);
                if (nakit != null)
                {
                    nakit.U_kosarici = true; // Update the value

                    db.Entry(nakit).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    return HttpNotFound();
                }
            }

            var model = db.Nakit.ToList();
            return View(model);
        }


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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdNakit,Novo,MaterijalNakit,VelicinaNakita,Boje,Spol,Cijena,VrstaNakita")] Nakit nakit)
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

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdNakit,Novo,MaterijalNakit,VelicinaNakita,Boje,Spol,Cijena,VrstaNakita")] Nakit nakit)
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
