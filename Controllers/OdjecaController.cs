using Secondhandshop1.Models;
using SecondHandShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SecondHandShop1.Controllers
{
    public class OdjecaController : Controller
    {
        private BazaDbContext db = new BazaDbContext();


        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                Odjeca odjeca = db.Odjeca.Find(id);
                if (odjeca != null)
                {
                    odjeca.U_kosarici = true; // Update the value

                    db.Entry(odjeca).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    return HttpNotFound();
                }
            }

            var model = db.Odjeca.ToList();
            return View(model);
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


        //POST: Odjeca/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOdjeca, Novo, MaterijalOdjeca, VelicinaOdjeca, Boje, Spol, Cijena, VrstaOdjece")] Odjeca odjeca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odjeca).State = System.Data.Entity.EntityState.Modified;
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
        public ActionResult Create([Bind(Include = "IdOdjeca,Novo,MaterijalOdjeca,VelicinaOdjeca,Boje,Spol,Cijena,VrstaOdjece")] Odjeca odjeca)
        {
            if (ModelState.IsValid)
            {
               
                Odjeca odjeca1= db.Odjeca.Add(odjeca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(odjeca);
        }

    }
}