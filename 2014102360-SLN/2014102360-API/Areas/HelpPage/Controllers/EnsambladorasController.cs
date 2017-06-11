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
    public class EnsambladorasController : Controller
    {
        private EnsambladoraDbContext db = new EnsambladoraDbContext();

        // GET: HelpPage/Ensambladoras
        public ActionResult Index()
        {
            return View(db.Ensambladoras.ToList());
        }

        // GET: HelpPage/Ensambladoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ensambladora ensambladora = db.Ensambladoras.Find(id);
            if (ensambladora == null)
            {
                return HttpNotFound();
            }
            return View(ensambladora);
        }

        // GET: HelpPage/Ensambladoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelpPage/Ensambladoras/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EnsambladoraId,_Ensambladora,TipoCarro")] Ensambladora ensambladora)
        {
            if (ModelState.IsValid)
            {
                db.Ensambladoras.Add(ensambladora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ensambladora);
        }

        // GET: HelpPage/Ensambladoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ensambladora ensambladora = db.Ensambladoras.Find(id);
            if (ensambladora == null)
            {
                return HttpNotFound();
            }
            return View(ensambladora);
        }

        // POST: HelpPage/Ensambladoras/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EnsambladoraId,_Ensambladora,TipoCarro")] Ensambladora ensambladora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ensambladora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ensambladora);
        }

        // GET: HelpPage/Ensambladoras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ensambladora ensambladora = db.Ensambladoras.Find(id);
            if (ensambladora == null)
            {
                return HttpNotFound();
            }
            return View(ensambladora);
        }

        // POST: HelpPage/Ensambladoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ensambladora ensambladora = db.Ensambladoras.Find(id);
            db.Ensambladoras.Remove(ensambladora);
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
