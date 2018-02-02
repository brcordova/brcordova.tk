using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MF_Modelo;
using NLog;

namespace SIIFMFv2_FE.Controllers
{
    public class AbonoController : Controller
    {
        private SPEIContext db = new SPEIContext();
        private Cuenta_Abono abono = new Cuenta_Abono();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        // GET: Abono
        //public ActionResult Index()
        //{
        //    return View(db.Cuenta_Abono.ToList());
        //}

        public ActionResult Index(int status = 0)
        {
            if (Request.QueryString.Count >= 2)
            {
                string strFechaInicio = Request.QueryString["dtpFecInicio"].ToString();
                string strFechaFinal = Request.QueryString["dtpFecFinal"].ToString();
            }

            ViewBag.Filtro = "Todos los registros";
            switch (status)
            {
                case 10:
                    ViewBag.Filtro = "Abonos registrados";
                    break;
                case 20:
                    ViewBag.Filtro = "Abonos activos";
                    break;
                case 30:
                    ViewBag.Filtro = "Abonos inactivos";
                    break;
                case 40:
                    ViewBag.Filtro = "Abonos rechazados";
                    break;
                case 50:
                    ViewBag.Filtro = "Abonos cancelados";
                    break;
            }

            if (status == 0)
                return View(abono.ObtenerAbonos());
            else
                return View(abono.ObtenerAbonos(status));

            //return View(db.Cuenta_Abono.ToList());
        }

        public JsonResult Listar(AnexGRIDprop agrid)
        {
            JsonResult respuesta = null;
            try
            {
                respuesta = Json(abono.Listar(agrid), JsonRequestBehavior.AllowGet);
            }

            catch (Exception ex)
            {
                log.Error(ex, "Error AbonoController/Listar");
            }

            return respuesta;
        }

        public JsonResult Nombre()
        {
            return Json("Ricardo Ostos", JsonRequestBehavior.AllowGet);
        }

        public JsonResult Listado()
        {
            JsonResult respuesta = null;
            try
            {
                respuesta = Json(db.Cuenta_Abono.ToList(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error AbonoController/Listado");
            }


            return respuesta;
        }

        // GET: Abono/Details/5
        public ActionResult Details(int? id)
        {
            int Id = 0;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
                Id = (int)id;

            Cuenta_Abono cuenta_Abono = (from ca in db.Cuenta_Abono
                                             where ca.Id == Id
                                             select ca ).FirstOrDefault();

            Cuenta_Abono_Respuesta caRespuesta = db.Cuenta_Abono_Respuesta.FirstOrDefault(z => z.Cuenta_Abono_Respuesta_clave == Id);

            //(from car in db.Cuenta_Abono_Respuesta
                // where car.Cuenta_Abono_Respuesta_clave == Id
                // select car).FirstOrDefault();

            ViewBag.caRespuesta = caRespuesta;

            if (cuenta_Abono == null)
            {
                return HttpNotFound();
            }
            return View(cuenta_Abono);
        }

        // GET: Abono/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Abono/Create
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

        // GET: Abono/Edit/5
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

        // POST: Abono/Edit/5
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

        // GET: Abono/Delete/5
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

        // POST: Abono/Delete/5
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

        [HttpGet]
        public JsonResult ObtenerEstadisticas()
        {
            Cuenta_Abono ca = new Cuenta_Abono();
            List<EstadisticaCA> lista = ca.DatosEstadisticos();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }   

    }
}
