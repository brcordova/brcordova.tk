namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Linq;

    public partial class Cuenta_Abono
    {

        SPEIContext db = new SPEIContext();

        #region Miembros
        public int Id { get; set; }

        public int Cuenta_Abono_Id { get; set; }

        public DateTime Cuenta_Abono_fechaOperacion { get; set; }

        public DateTime Cuenta_Abono_fechaRegistro { get; set; }

        public int? Cuenta_Abono_institucionOrdenante { get; set; }

        public int? Cuenta_Abono_institucionBeneficiaria { get; set; }

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
        #endregion

        #region Métodos


        /// <summary>
        /// Verifica si existe la CLABE
        /// </summary>
        /// <param name="strCLABE">La CLABE del pago recibido</param>
        /// <returns>En caso de existir devuelve verdadero</returns>
        public bool BuscaCLABE(string strCLABE)
        {
            bool resultado = false;

            using (var context = new SPEIContext())
            {
                var CLABE = new SqlParameter("@Cuenta_Clabe_CLABE", 1);
                var registros = new SqlParameter("@RegistroExistente", 0)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                resultado = context.Database.SqlQuery<bool>("[SPEI].[dbo].[sp_s_BuscaCLABE] @Cuenta_Clabe_CLABE, @RegistroExistente OUT", CLABE, registros).Single();

                if (Convert.ToInt32(resultado) > 0)
                    resultado = true;
                else
                    resultado = false;
            }

           
            return resultado;

        }

        public void Agrega()
        {
            
            db.Cuenta_Abono.Add(this);
            db.SaveChanges();

        }


        #endregion
    }
}
