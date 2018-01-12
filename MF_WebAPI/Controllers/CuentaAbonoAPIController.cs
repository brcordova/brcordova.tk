using MF_Modelo;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace MF_WebAPI.Controllers
{
    public class CuentaAbonoAPIController : ApiController
    {
        private SPEIContext db = new SPEIContext();

        // GET: api/CuentaAbonoAPI
        public IQueryable<Cuenta_Abono> GetCuenta_Abono()
        {
            return db.Cuenta_Abono;
        }

        // GET: api/CuentaAbonoAPI/5
        [ResponseType(typeof(Cuenta_Abono))]
        public IHttpActionResult GetCuenta_Abono(int id)
        {
            Cuenta_Abono cuenta_Abono = db.Cuenta_Abono.Find(id);
            if (cuenta_Abono == null)
            {
                return NotFound();
            }

            return Ok(cuenta_Abono);
        }

        // PUT: api/CuentaAbonoAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCuenta_Abono(int id, Cuenta_Abono cuenta_Abono)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cuenta_Abono.Id)
            {
                return BadRequest();
            }

            db.Entry(cuenta_Abono).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Cuenta_AbonoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CuentaAbonoAPI
        [ResponseType(typeof(Cuenta_Abono))]
        public IHttpActionResult PostCuenta_Abono(Cuenta_Abono cuenta_Abono)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cuenta_Abono.Add(cuenta_Abono);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cuenta_Abono.Id }, cuenta_Abono);
        }

        // DELETE: api/CuentaAbonoAPI/5
        [ResponseType(typeof(Cuenta_Abono))]
        public IHttpActionResult DeleteCuenta_Abono(int id)
        {
            Cuenta_Abono cuenta_Abono = db.Cuenta_Abono.Find(id);
            if (cuenta_Abono == null)
            {
                return NotFound();
            }

            db.Cuenta_Abono.Remove(cuenta_Abono);
            db.SaveChanges();

            return Ok(cuenta_Abono);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Cuenta_AbonoExists(int id)
        {
            return db.Cuenta_Abono.Count(e => e.Id == id) > 0;
        }
    }
}