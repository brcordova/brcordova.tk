using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MF_Modelo;

namespace MF_WebAPI.Controllers
{
    public class CuentaAbonoController : Controller
    {
        private SPEIContext db = new SPEIContext();

        // GET: CuentaAbono
        public ActionResult Index()
        {
            return View(db.Cuenta_Abono.ToList());
        }

        // GET: CuentaAbono/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta_Abono cuenta_Abono = db.Cuenta_Abono.Find(id);
            if (cuenta_Abono == null)
            {
                return HttpNotFound();
            }
            return View(cuenta_Abono);
        }

        // GET: CuentaAbono/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentaAbono/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Cuenta_Abono_Id,Cuenta_Abono_fechaOperacion,Cuenta_Abono_fechaRegistro,Cuenta_Abono_institucionOrdenante,Cuenta_Abono_institucionBeneficiaria,Cuenta_Abono_claveRastreo,Cuenta_Abono_monto,Cuenta_Abono_nombreOrdenante,Cuenta_Abono_tipoCuentaOrdenante,Cuenta_Abono_cuentaOrdenante,Cuenta_Abono_rfcCurpOrdenante,Cuenta_Abono_nombreBeneficiario,Cuenta_Abono_tipoCuentaBeneficiario,Cuenta_Abono_cuentaBeneficiario,Cuenta_Abono_rfcCurpBeneficiario,Cuenta_Abono_conceptoPago,Cuenta_Abono_referenciaNumerica,Cuenta_Abono_empresa,Cuenta_Abono_tipoPago,Cuenta_Abono_tipoOperacion,Cuenta_Abono_Sts_Conciliacion,Cuenta_Abono_claveRastreoDev,Cuenta_Abono_Sts_Abono_Id")] Cuenta_Abono cuenta_Abono)
        {
            if (ModelState.IsValid)
            {
                db.Cuenta_Abono.Add(cuenta_Abono);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuenta_Abono);
        }

        // GET: CuentaAbono/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta_Abono cuenta_Abono = db.Cuenta_Abono.Find(id);
            if (cuenta_Abono == null)
            {
                return HttpNotFound();
            }
            return View(cuenta_Abono);
        }

        // POST: CuentaAbono/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cuenta_Abono_Id,Cuenta_Abono_fechaOperacion,Cuenta_Abono_fechaRegistro,Cuenta_Abono_institucionOrdenante,Cuenta_Abono_institucionBeneficiaria,Cuenta_Abono_claveRastreo,Cuenta_Abono_monto,Cuenta_Abono_nombreOrdenante,Cuenta_Abono_tipoCuentaOrdenante,Cuenta_Abono_cuentaOrdenante,Cuenta_Abono_rfcCurpOrdenante,Cuenta_Abono_nombreBeneficiario,Cuenta_Abono_tipoCuentaBeneficiario,Cuenta_Abono_cuentaBeneficiario,Cuenta_Abono_rfcCurpBeneficiario,Cuenta_Abono_conceptoPago,Cuenta_Abono_referenciaNumerica,Cuenta_Abono_empresa,Cuenta_Abono_tipoPago,Cuenta_Abono_tipoOperacion,Cuenta_Abono_Sts_Conciliacion,Cuenta_Abono_claveRastreoDev,Cuenta_Abono_Sts_Abono_Id")] Cuenta_Abono cuenta_Abono)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuenta_Abono).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuenta_Abono);
        }

        // GET: CuentaAbono/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cuenta_Abono cuenta_Abono = db.Cuenta_Abono.Find(id);
            if (cuenta_Abono == null)
            {
                return HttpNotFound();
            }
            return View(cuenta_Abono);
        }

        // POST: CuentaAbono/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cuenta_Abono cuenta_Abono = db.Cuenta_Abono.Find(id);
            db.Cuenta_Abono.Remove(cuenta_Abono);
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
