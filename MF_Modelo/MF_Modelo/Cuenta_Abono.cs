namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using NLog;

    public partial class Cuenta_Abono
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        private static readonly SPEIContext db = new SPEIContext();
        private static EstadisticaCA eca = new EstadisticaCA();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        #region Constructor
        public Cuenta_Abono()
        {
            Cuenta_Abono_Respuesta = new HashSet<Cuenta_Abono_Respuesta>();
        }
        #endregion

        #region Propiedades
        public int Id { get; set; }

        public int Cuenta_Abono_Id { get; set; }

        public DateTime Cuenta_Abono_fechaOperacion { get; set; }

        public DateTime Cuenta_Abono_fechaRegistro { get; set; }

        public int Cuenta_Abono_institucionOrdenante { get; set; }

        public int Cuenta_Abono_institucionBeneficiaria { get; set; }

        [StringLength(30)]
        public string Cuenta_Abono_claveRastreo { get; set; }

        public decimal? Cuenta_Abono_monto { get; set; }

        [StringLength(80)]
        public string Cuenta_Abono_nombreOrdenante { get; set; }

        public int? Cuenta_Abono_tipoCuentaOrdenante { get; set; }

        [StringLength(18)]
        public string Cuenta_Abono_cuentaOrdenante { get; set; }

        [StringLength(18)]
        public string Cuenta_Abono_rfcCurpOrdenante { get; set; }

        [StringLength(80)]
        public string Cuenta_Abono_nombreBeneficiario { get; set; }

        public int? Cuenta_Abono_tipoCuentaBeneficiario { get; set; }

        [StringLength(18)]
        public string Cuenta_Abono_cuentaBeneficiario { get; set; }

        [StringLength(18)]
        public string Cuenta_Abono_rfcCurpBeneficiario { get; set; }

        [StringLength(80)]
        public string Cuenta_Abono_conceptoPago { get; set; }

        public int? Cuenta_Abono_referenciaNumerica { get; set; }

        [StringLength(80)]
        public string Cuenta_Abono_empresa { get; set; }

        public int? Cuenta_Abono_tipoPago { get; set; }

        public int? Cuenta_Abono_tipoOperacion { get; set; }

        public short? Cuenta_Abono_Sts_Conciliacion { get; set; }

        [StringLength(30)]
        public string Cuenta_Abono_claveRastreoDev { get; set; }

        public int? Cuenta_Abono_Sts_Abono_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuenta_Abono_Respuesta> Cuenta_Abono_Respuesta { get; set; }
        #endregion


        #region Métodos

        public bool Agregar()
        {
            bool ret = false;

            try
            {
                Cuenta_Abono_fechaRegistro = DateTime.Now;
                db.Cuenta_Abono.Add(this);
                db.SaveChanges();
                ret = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return ret;
        }

        public List<EstadisticaCA> DatosEstadisticos()
        {
            List<EstadisticaCA> listaECA = eca.listaEstadistica();
            return listaECA;
        }

        public List<Cuenta_Abono> ObtenerAbonos(int? status = 0)
        {
            //List<Cuenta_Abono> lstAbonos = new List<Cuenta_Abono>();

            var abonos = (from ca in db.Cuenta_Abono
                          select ca);
            if (status > 0)
            {
                abonos = (from ca in abonos
                          where ca.Cuenta_Abono_Sts_Abono_Id == status
                          select ca);
            }

            return abonos.ToList();
        }

        #endregion



    }
}
