﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Negocio.Data;
using Negocio.Models;

namespace Negocio.Controllers
{
    public class UnidadMedidaController : Controller
    {
        private TiendaContex db = new TiendaContex();

        // GET: UnidadMedida
        public ActionResult Index()
        {
            return View(db.UnidadMedidas.ToList());
        }

        // GET: UnidadMedida/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadMedida unidadMedida = db.UnidadMedidas.Find(id);
            if (unidadMedida == null)
            {
                return HttpNotFound();
            }
            return View(unidadMedida);
        }

        // GET: UnidadMedida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadMedida/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UnidadMedidaId,Codigo,Descripcion,Estado,FechaCreacion,FechaModificacion")] UnidadMedida unidadMedida)
        {
            if (ModelState.IsValid)
            {
                db.UnidadMedidas.Add(unidadMedida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unidadMedida);
        }

        // GET: UnidadMedida/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadMedida unidadMedida = db.UnidadMedidas.Find(id);
            if (unidadMedida == null)
            {
                return HttpNotFound();
            }
            return View(unidadMedida);
        }

        // POST: UnidadMedida/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UnidadMedidaId,Codigo,Descripcion,Estado,FechaCreacion,FechaModificacion")] UnidadMedida unidadMedida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unidadMedida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unidadMedida);
        }

        // GET: UnidadMedida/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidadMedida unidadMedida = db.UnidadMedidas.Find(id);
            if (unidadMedida == null)
            {
                return HttpNotFound();
            }
            return View(unidadMedida);
        }

        // POST: UnidadMedida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnidadMedida unidadMedida = db.UnidadMedidas.Find(id);
            db.UnidadMedidas.Remove(unidadMedida);
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
