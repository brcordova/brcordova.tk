namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity;
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
        [Key]
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

        public bool Actualizar()
        {
            bool ret = false;

            try
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                ret = true;
            }
            catch (Exception ex)
            {
                log.Error(ex, "Cuenta_Abono/Actualizar");
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

        public AnexGRIDResponde Listar(AnexGRIDprop agrid)
        {
            try
            {
                using (var ctx = new SPEIContext())
                {
                    agrid.Inicializar();

                    DateTime dtFecIni = DateTime.Now;
                    DateTime dtFecFin = DateTime.Now;

                    if (agrid.parametros.Count() > 0)
                    {
                        dtFecIni = agrid.parametros[0].valor == null ?
                            DateTime.Now : Convert.ToDateTime(agrid.parametros[0].valor.ToString());

                        dtFecFin = agrid.parametros[1].valor == null ?
                            DateTime.Now : Convert.ToDateTime(agrid.parametros[1].valor.ToString());

                        if (dtFecFin < dtFecIni)
                            dtFecFin = dtFecIni;
                    }
                    var query = ctx.Cuenta_Abono
                        .Where(ca => ca.Id > 0 &&
                            DbFunctions.TruncateTime(ca.Cuenta_Abono_fechaRegistro) >= DbFunctions.TruncateTime(dtFecIni) && DbFunctions.TruncateTime(ca.Cuenta_Abono_fechaRegistro) <= DbFunctions.TruncateTime(dtFecIni)
                            );

                    // Ordenar 
                    if (agrid.columna == "Id") query = agrid.columna_orden == "DESC"
                                                       ? query.OrderByDescending(x => x.Id)
                                                       : query.OrderBy(x => x.Id);

                    if (agrid.columna == "Cuenta_Abono_nombreOrdenante") query = agrid.columna_orden == "DESC"
                                                       ? query.OrderByDescending(x => x.Cuenta_Abono_nombreOrdenante)
                                                       : query.OrderBy(x => x.Cuenta_Abono_nombreOrdenante);

                    if (agrid.columna == "Cuenta_Abono_fechaOperacion") query = agrid.columna_orden == "DESC"
                                                       ? query.OrderByDescending(x => x.Cuenta_Abono_fechaOperacion)
                                                       : query.OrderBy(x => x.Cuenta_Abono_fechaOperacion);

                    if (agrid.columna == "Cuenta_Abono_fechaRegistro") query = agrid.columna_orden == "DESC"
                                                       ? query.OrderByDescending(x => x.Cuenta_Abono_fechaRegistro)
                                                       : query.OrderBy(x => x.Cuenta_Abono_fechaRegistro);

                    // Filtrar
                    foreach (var f in agrid.filtros)
                    {
                        if (f.columna == "Cuenta_Abono_nombreOrdenante")
                            query = query.Where(x => x.Cuenta_Abono_nombreOrdenante.Contains(f.valor));

                        //if (f.columna == "Correo")
                        //    query = query.Where(x => x.Correo.StartsWith(f.valor));

                        if (f.columna == "Cuenta_Abono_fechaRegistro" && f.valor != "")
                        {
                            var fecSol = f.valor.ToString().Trim();
                            DateTime fecSolVal = DateTime.Parse(fecSol);
                            query = query.Where(x => x.Cuenta_Abono_fechaRegistro.ToString().Contains(f.valor));
                        }
                    }

                    var abonos = query.Skip(agrid.pagina)
                                         .Take(agrid.limite)
                                         .ToList();

                    agrid.SetData(
                            from a in abonos
                            select new
                            {
                                a.Id,
                                a.Cuenta_Abono_nombreOrdenante,
                                a.Cuenta_Abono_cuentaOrdenante,
                                a.Cuenta_Abono_fechaOperacion,
                                a.Cuenta_Abono_monto,
                                a.Cuenta_Abono_fechaRegistro,
                                a.Cuenta_Abono_conceptoPago,
                                a.Cuenta_Abono_Sts_Abono_Id
                            }
                        ,
                        query.Count()
                    );
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return agrid.responde();
        }

        public Cuenta_Abono ObtenerAbonoId(int intId)
        {
            Cuenta_Abono cuentaAbono = (from ca in db.Cuenta_Abono
                                        where ca.Cuenta_Abono_Id == intId
                                        select ca).FirstOrDefault();

            return cuentaAbono;
        }

        #endregion
    }
}
