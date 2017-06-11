﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2014102360_ENT;
using _2014102360_PER;

namespace _2014102360_API.Areas.HelpPage.Controllers
{
    public class CinturonesController : Controller
    {
        private EnsambladoraDbContext db = new EnsambladoraDbContext();

        // GET: HelpPage/Cinturones
        public ActionResult Index()
        {
            return View(db.Cinturones.ToList());
        }

        // GET: HelpPage/Cinturones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturones.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // GET: HelpPage/Cinturones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelpPage/Cinturones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinturonId,NumSerieCinturon,Metraje")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                db.Cinturones.Add(cinturon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cinturon);
        }

        // GET: HelpPage/Cinturones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturones.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // POST: HelpPage/Cinturones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinturonId,NumSerieCinturon,Metraje")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinturon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cinturon);
        }

        // GET: HelpPage/Cinturones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturones.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // POST: HelpPage/Cinturones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cinturon cinturon = db.Cinturones.Find(id);
            db.Cinturones.Remove(cinturon);
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
