using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using NLog;

namespace MF_Modelo
{
    public partial class Cuenta_Abono_Respuesta
    {

        public static readonly SPEIContext db = new SPEIContext();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        #region Propiedades
        public int Id { get; set; }

        public int Cuenta_Abono_Respuesta_Id { get; set; }

        public int Cuenta_Abono_Respuesta_clave { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_empresa { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_medioEntrega { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_folioOrigen { get; set; }

        public int Cuenta_Abono_Respuesta_codigoError { get; set; }

        public int Cuenta_Abono_Respuesta_tipoPago { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_rastreoDevolucion { get; set; }

        public DateTime Cuenta_Abono_Respuesta_fechaRegistro { get; set; }

        [ForeignKey("Cuenta_Abono_Respuesta_clave")]
        public virtual Cuenta_Abono Cuenta_Abono { get; set; }

        #endregion

        #region Métodos
        public void Agrega()
        {
            try
            {
                Cuenta_Abono_Respuesta_Id = (maximoValor() + 1);
                Cuenta_Abono_Respuesta_fechaRegistro = DateTime.Now;
                db.Cuenta_Abono_Respuesta.Add(this);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int maximoValor()
        {

            var datos = db.Cuenta_Abono_Respuesta.Count();

            int idMax = 0;
            try
            {
                var vIdMax = (from car in db.Cuenta_Abono_Respuesta
                         select car.Cuenta_Abono_Respuesta_Id).Max();
                if (vIdMax > 0)
                    idMax = (int)vIdMax;
            }
            catch (Exception ex)
            {
                idMax = 1;

            }

            

            return idMax;
        }
        #endregion


    }
}
