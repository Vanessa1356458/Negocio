using System;
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
    public class GrupoDescuentoController : Controller
    {
        private TiendaContex db = new TiendaContex();

        // GET: GrupoDescuento
        public ActionResult Index()
        {
            return View(db.GrupoDescuentoes.ToList());
        }

        // GET: GrupoDescuento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoDescuento grupoDescuento = db.GrupoDescuentoes.Find(id);
            if (grupoDescuento == null)
            {
                return HttpNotFound();
            }
            return View(grupoDescuento);
        }

        // GET: GrupoDescuento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrupoDescuento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GrupoDescuentoId,Codigo,Descripcion,Estado,Porcentaje,FechaCreacion,FechaModificacion")] GrupoDescuento grupoDescuento)
        {
            if (ModelState.IsValid)
            {
                db.GrupoDescuentoes.Add(grupoDescuento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grupoDescuento);
        }

        // GET: GrupoDescuento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoDescuento grupoDescuento = db.GrupoDescuentoes.Find(id);
            if (grupoDescuento == null)
            {
                return HttpNotFound();
            }
            return View(grupoDescuento);
        }

        // POST: GrupoDescuento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GrupoDescuentoId,Codigo,Descripcion,Estado,Porcentaje,FechaCreacion,FechaModificacion")] GrupoDescuento grupoDescuento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupoDescuento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupoDescuento);
        }

        // GET: GrupoDescuento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoDescuento grupoDescuento = db.GrupoDescuentoes.Find(id);
            if (grupoDescuento == null)
            {
                return HttpNotFound();
            }
            return View(grupoDescuento);
        }

        // POST: GrupoDescuento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GrupoDescuento grupoDescuento = db.GrupoDescuentoes.Find(id);
            db.GrupoDescuentoes.Remove(grupoDescuento);
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
