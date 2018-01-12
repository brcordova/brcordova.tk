namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuenta_Abono_Respuesta
    {
        SPEIContext db = new SPEIContext();

        #region Miembros
        public int Id { get; set; }

        public int? Cuenta_Abono_Respuesta_Id { get; set; }

        public int? Cuenta_Abono_Respuesta_clave { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_empresa { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_medioEntrega { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_folioOrigen { get; set; }

        public int? Cuenta_Abono_Respuesta_codigoError { get; set; }

        public int? Cuenta_Abono_Respuesta_tipoPago { get; set; }

        [StringLength(10)]
        public string Cuenta_Abono_Respuesta_rastreoDevolucion { get; set; }

        public DateTime? Cuenta_Abono_Respuesta_fechaRegistro { get; set; }
        #endregion 

        #region Métodos
        public void Agrega()
        {
            db.Cuenta_Abono_Respuesta.Add(this);
            db.SaveChanges();
        }
        #endregion

    }
}
