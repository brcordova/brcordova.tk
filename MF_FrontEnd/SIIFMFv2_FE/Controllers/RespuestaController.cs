using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MF_Modelo;

namespace SIIFMFv2_FE.Controllers
{
    public class RespuestaController : Controller
    {
        private SPEIContext db = new SPEIContext();

        // GET: Respuesta
        public ActionResult Index()
        {
            return View(db.Cuenta_Abono_Respuesta.ToList());
        }

        // GET: Respuesta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta_Abono_Respuesta cuenta_Abono_Respuesta = db.Cuenta_Abono_Respuesta.Find(id);
            if (cuenta_Abono_Respuesta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta_Abono_Respuesta);
        }

        // GET: Respuesta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Respuesta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Cuenta_Abono_Respuesta_Id,Cuenta_Abono_Respuesta_clave,Cuenta_Abono_Respuesta_empresa,Cuenta_Abono_Respuesta_medioEntrega,Cuenta_Abono_Respuesta_folioOrigen,Cuenta_Abono_Respuesta_codigoError,Cuenta_Abono_Respuesta_tipoPago,Cuenta_Abono_Respuesta_rastreoDevolucion,Cuenta_Abono_Respuesta_fechaRegistro")] Cuenta_Abono_Respuesta cuenta_Abono_Respuesta)
        {
            if (ModelState.IsValid)
            {
                db.Cuenta_Abono_Respuesta.Add(cuenta_Abono_Respuesta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuenta_Abono_Respuesta);
        }

        // GET: Respuesta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta_Abono_Respuesta cuenta_Abono_Respuesta = db.Cuenta_Abono_Respuesta.Find(id);
            if (cuenta_Abono_Respuesta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta_Abono_Respuesta);
        }

        // POST: Respuesta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cuenta_Abono_Respuesta_Id,Cuenta_Abono_Respuesta_clave,Cuenta_Abono_Respuesta_empresa,Cuenta_Abono_Respuesta_medioEntrega,Cuenta_Abono_Respuesta_folioOrigen,Cuenta_Abono_Respuesta_codigoError,Cuenta_Abono_Respuesta_tipoPago,Cuenta_Abono_Respuesta_rastreoDevolucion,Cuenta_Abono_Respuesta_fechaRegistro")] Cuenta_Abono_Respuesta cuenta_Abono_Respuesta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuenta_Abono_Respuesta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuenta_Abono_Respuesta);
        }

        // GET: Respuesta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta_Abono_Respuesta cuenta_Abono_Respuesta = db.Cuenta_Abono_Respuesta.Find(id);
            if (cuenta_Abono_Respuesta == null)
            {
                return HttpNotFound();
            }
            return View(cuenta_Abono_Respuesta);
        }

        // POST: Respuesta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cuenta_Abono_Respuesta cuenta_Abono_Respuesta = db.Cuenta_Abono_Respuesta.Find(id);
            db.Cuenta_Abono_Respuesta.Remove(cuenta_Abono_Respuesta);
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
