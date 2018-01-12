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

namespace MF_WebAPI.Controllers
{
    public class BitacoraController : ApiController
    {
        private SPEIContext db = new SPEIContext();

        // GET: api/Bitacora
        /// <summary>
        /// Obtiene todas las bitacoras
        /// </summary>
        /// <returns>Listado de bitacoras</returns>
        public IQueryable<Bitacora> GetBitacora()
        {
            return db.Bitacora;
        }

        // GET: api/Bitacora/5
        /// <summary>
        /// Obtiene una bitacora en especifico
        /// </summary>
        /// <param name="id">Id de la bitacora</param>
        /// <returns>Bitacora solicitada</returns>
        [ResponseType(typeof(Bitacora))]
        public IHttpActionResult GetBitacora(int id)
        {
            Bitacora bitacora = db.Bitacora.Find(id);
            if (bitacora == null)
            {
                return NotFound();
            }

            return Ok(bitacora);
        }

        // PUT: api/Bitacora/5
        /// <summary>
        /// Guarda una bitacora
        /// </summary>
        /// <param name="id">Id de la bitacora</param>
        /// <param name="bitacora">Bitacora</param>
        /// <returns>Resultado del evento.</returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBitacora(int id, Bitacora bitacora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bitacora.ID)
            {
                return BadRequest();
            }

            db.Entry(bitacora).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BitacoraExists(id))
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

        // POST: api/Bitacora
        [ResponseType(typeof(Bitacora))]
        public IHttpActionResult PostBitacora(Bitacora bitacora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bitacora.Add(bitacora);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bitacora.ID }, bitacora);
        }

        // DELETE: api/Bitacora/5
        [ResponseType(typeof(Bitacora))]
        public IHttpActionResult DeleteBitacora(int id)
        {
            Bitacora bitacora = db.Bitacora.Find(id);
            if (bitacora == null)
            {
                return NotFound();
            }

            db.Bitacora.Remove(bitacora);
            db.SaveChanges();

            return Ok(bitacora);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BitacoraExists(int id)
        {
            return db.Bitacora.Count(e => e.ID == id) > 0;
        }
    }
}