using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MF_Modelo;

namespace MF_WebAPI.Controllers
{
    /// <summary>
    /// Servicio principal de MF
    /// </summary>
    public class ServiciosMFController : ApiController
    {
        private readonly SPEIContext db = new SPEIContext();
        
        // GET: api/student
        /// <summary>
        /// Obtiene todos los registros
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Bitacora> Get()
        {
            return db.Bitacora.ToList();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/student/5
        /// <summary>
        /// Obtiene un registro
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        /// <returns>Valor del registro buscado</returns>
        /// <example>dasdasd</example>
        /// <value>asdasd</value>
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/student
        /// <summary>
        /// Envia los valores solicitados.
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value) { }

        // PUT: api/student/5
        public void Put(int id, [FromBody]string value) { }

        // DELETE: api/student/5
        /// <summary>
        /// Elimina un registro
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id) { }

        /// <summary>
        /// Recibe un registro de abono
        /// </summary>
        /// <returns></returns>
        //[HttpPost]
        [AcceptVerbs("Post")]
        public HttpResponseMessage recibeAbono()
        {
            var products = db.Cuenta_Abono.ToList();
            if (products.Any())
                return Request.CreateResponse(HttpStatusCode.OK, products);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No data found.");
        }


    }
}
