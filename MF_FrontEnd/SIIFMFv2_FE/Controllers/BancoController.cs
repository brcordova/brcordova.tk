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
    public class BancoController : Controller
    {
        private SPEIContext db = new SPEIContext();

        // GET: Banco
        public ActionResult Index()
        {
            return View(db.Banco.ToList());
        }

        // GET: Banco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // GET: Banco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Banco/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Banco_Id,Banco_Dsc,Banco_Dsc_Corta,Banco_Clave_CNBV,Banco_Opera_Digito,Banco_Clave_Financiera,Banco_Cuenta_Contable,Banco_Habilitado,Banco_Permite_ModCtaCientes,Banco_Certifica_CuentaClientes,Banco_GeneraLayout_CertificacionCta,Banco_ConfirmaLayout_CertificacionCta,Banco_Longitud_Cuenta,Banco_Maneja_Domiciliacion,Banco_RequiereAltaBaja_Domiciliacion,Banco_Clave_Banxico")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Banco.Add(banco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(banco);
        }

        // GET: Banco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // POST: Banco/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Banco_Id,Banco_Dsc,Banco_Dsc_Corta,Banco_Clave_CNBV,Banco_Opera_Digito,Banco_Clave_Financiera,Banco_Cuenta_Contable,Banco_Habilitado,Banco_Permite_ModCtaCientes,Banco_Certifica_CuentaClientes,Banco_GeneraLayout_CertificacionCta,Banco_ConfirmaLayout_CertificacionCta,Banco_Longitud_Cuenta,Banco_Maneja_Domiciliacion,Banco_RequiereAltaBaja_Domiciliacion,Banco_Clave_Banxico")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banco);
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // POST: Banco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Banco banco = db.Banco.Find(id);
            db.Banco.Remove(banco);
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
