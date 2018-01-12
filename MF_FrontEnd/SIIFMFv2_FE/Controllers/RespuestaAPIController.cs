using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MF_Modelo;

namespace SIIFMFv2_FE.Controllers
{
    public class RespuestaAPIController : ApiController
    {
        private SPEIContext db = new SPEIContext();

        // Obtiene un listado de todos los registros (cRud)
        // GET: api/RespuestaAPI
        public IQueryable<Cuenta_Abono_Respuesta> GetCuenta_Abono_Respuesta()
        {
            return db.Cuenta_Abono_Respuesta;
        }

        // Obtiene un registro (cRud)
        // GET: api/RespuestaAPI/5
        [ResponseType(typeof(Cuenta_Abono_Respuesta))]
        public IHttpActionResult GetCuenta_Abono_Respuesta(int id)
        {
            Cuenta_Abono_Respuesta cuenta_Abono_Respuesta = db.Cuenta_Abono_Respuesta.Find(id);
            if (cuenta_Abono_Respuesta == null)
            {
                return NotFound();
            }

            return Ok(cuenta_Abono_Respuesta);
        }


        // Actualiza/Modifca un registro (crUd)
        // PUT: api/RespuestaAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCuenta_Abono_Respuesta(int id, Cuenta_Abono_Respuesta cuenta_Abono_Respuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cuenta_Abono_Respuesta.Id)
            {
                return BadRequest();
            }

            db.Entry(cuenta_Abono_Respuesta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Cuenta_Abono_RespuestaExists(id))
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

        // Crea nuevo registro (Crud)
        // POST: api/RespuestaAPI
        [ResponseType(typeof(Cuenta_Abono_Respuesta))]
        public IHttpActionResult PostCuenta_Abono_Respuesta(Cuenta_Abono_Respuesta cuenta_Abono_Respuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cuenta_Abono_Respuesta.Add(cuenta_Abono_Respuesta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cuenta_Abono_Respuesta.Id }, cuenta_Abono_Respuesta);
        }

        // Elimina un registro (cruD)
        // DELETE: api/RespuestaAPI/5
        [ResponseType(typeof(Cuenta_Abono_Respuesta))]
        public IHttpActionResult DeleteCuenta_Abono_Respuesta(int id)
        {
            Cuenta_Abono_Respuesta cuenta_Abono_Respuesta = db.Cuenta_Abono_Respuesta.Find(id);
            if (cuenta_Abono_Respuesta == null)
            {
                return NotFound();
            }

            db.Cuenta_Abono_Respuesta.Remove(cuenta_Abono_Respuesta);
            db.SaveChanges();

            return Ok(cuenta_Abono_Respuesta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Cuenta_Abono_RespuestaExists(int id)
        {
            return db.Cuenta_Abono_Respuesta.Count(e => e.Id == id) > 0;
        }
    }
}