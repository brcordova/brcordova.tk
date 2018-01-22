using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MF_Modelo
{
    public class EstadisticaCA
    {
        private static readonly SPEIContext db = new SPEIContext();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        static string conStr = ConfigurationManager.ConnectionStrings["SPEIContext"].ConnectionString;

        public string strDscTipoEstatus { get; set; }
        public int intCveTipoEstatus { get; set; }
        public int intTotalRegistros { get; set; }
        public decimal decPcteRegistro { get; set; }
        private int intTotalReg;

        public EstadisticaCA() { }

        public List<EstadisticaCA> listaEstadistica()
        {
            List<EstadisticaCA> retLista = new List<EstadisticaCA>();
            EstadisticaCA esta = null;

            #region Obtenemos el total de registros
            intTotalReg = db.Cuenta_Abono.Count();
            #endregion

            #region Obtenemos la lista
            var lista = (
                from sts in db.Sts_Abono
                orderby sts.Sts_Abono_Id
                select new {
                    Cve = sts.Sts_Abono_Id,
                    Dsc = sts.Sts_Abono_Dsc_Corta
                });

            foreach (var item in lista)
	        {
                esta = new EstadisticaCA();
                esta.intCveTipoEstatus = item.Cve;
                esta.strDscTipoEstatus=item.Dsc.Trim();
		        retLista.Add(esta);
	        }

            #endregion

            #region Actualizamos la lista

            var res = (
                from ca in db.Cuenta_Abono
                group ca.Cuenta_Abono_Sts_Abono_Id by ca.Cuenta_Abono_Sts_Abono_Id into resultados
                select new { Clave = resultados.Key,
                    Total = resultados.Count()
                });

            foreach (var item in res)
            {
                esta = new EstadisticaCA();
                int idReg = (int)item.Clave;
                int intTotalPorCve = item.Total;
                foreach (var lst in retLista)
                {
                    if (lst.intCveTipoEstatus == idReg)
                    {
                        lst.intTotalRegistros = intTotalPorCve;
                        decimal pctRes =
                            Convert.ToDecimal(
                            (Convert.ToDecimal(intTotalPorCve) / Convert.ToDecimal(intTotalReg)) * 100);
                        lst.decPcteRegistro = pctRes;
                    }
                }
            }

            #endregion

            return retLista;
        }

    }
}
