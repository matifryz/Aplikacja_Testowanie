using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplikacja1.DAL;
using Aplikacja1.Models;

namespace Aplikacja1.Controllers
{
    public class OsobasController : Controller
    {
        private OsobaContext db = new OsobaContext();

        // GET: Osobas
        public ActionResult Index()
        {
            return View(db.Osobas.ToList());
        }

        // GET: Osobas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba osoba = db.Osobas.Find(id);
            if (osoba == null)
            {
                return HttpNotFound();
            }
            return View(osoba);
        }

        // GET: Osobas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Osobas/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OsobaId,Imie,Nazwisko,Telefon")] Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                db.Osobas.Add(osoba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(osoba);
        }

        // GET: Osobas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba osoba = db.Osobas.Find(id);
            if (osoba == null)
            {
                return HttpNotFound();
            }
            return View(osoba);
        }

        // POST: Osobas/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OsobaId,Imie,Nazwisko,Telefon")] Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(osoba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(osoba);
        }

        // GET: Osobas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba osoba = db.Osobas.Find(id);
            if (osoba == null)
            {
                return HttpNotFound();
            }
            return View(osoba);
        }

        // POST: Osobas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Osoba osoba = db.Osobas.Find(id);
            db.Osobas.Remove(osoba);
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
