namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using NLog;

    [Table("Banco")]
    public partial class Banco
    {
        private static readonly SPEIContext db = new SPEIContext();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        #region Propiedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Banco_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Banco_Dsc { get; set; }

        [Required]
        [StringLength(15)]
        public string Banco_Dsc_Corta { get; set; }

        public int Banco_Clave_CNBV { get; set; }

        public bool Banco_Opera_Digito { get; set; }

        [Required]
        [StringLength(10)]
        public string Banco_Clave_Financiera { get; set; }

        [Required]
        [StringLength(4)]
        public string Banco_Cuenta_Contable { get; set; }

        public bool Banco_Habilitado { get; set; }

        public bool Banco_Permite_ModCtaCientes { get; set; }

        public bool Banco_Certifica_CuentaClientes { get; set; }

        public bool Banco_GeneraLayout_CertificacionCta { get; set; }

        public bool Banco_ConfirmaLayout_CertificacionCta { get; set; }

        public short Banco_Longitud_Cuenta { get; set; }

        public bool Banco_Maneja_Domiciliacion { get; set; }

        public bool Banco_RequiereAltaBaja_Domiciliacion { get; set; }

        public int Banco_Clave_Banxico { get; set; }
        #endregion

        #region Métodos

        // CRUD
        // Create - Read - Update - Delete
        // Agregar - Leer - Actualizar - Borrar

        public void Agrega()
        {

            try
            {
                //Cuenta_Abono_Respuesta_Id = (maximoValor() + 1);
                //Cuenta_Abono_Respuesta_fechaRegistro = DateTime.Now;
                //db.Cuenta_Abono_Respuesta.Add(this);
                db.Banco.Add(this);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(conStr))
            //    {
            //        SqlCommand cmd = new SqlCommand(
            //            "[SPEI].[dbo].[sp_i_AgregaRespuestaAbono]", conn);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.AddWithValue("@Banco_Dsc_Corta", banco_Dsc_Corta);
            //        cmd.Parameters.AddWithValue("@Banco_Clave_CNBV", banco_Clave_CNBV);

            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    log.Error(ex, "Error Banco/Agrega");
            //}
        }

        public void Actualiza(string strBancoClave, string strBancoNombre) 
        {

            int intCveBanco = Convert.ToInt32(strBancoClave);

            try
            {
                var banco = (from b in db.Banco
                             where b.Banco_Clave_Banxico == intCveBanco
                             select b);

                if (banco.Count() == 0)
                {
                    // Insertar el banco
                }
                else
                { 
                    // Modificar ?
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error en Banco/Actualiza");
            }

            
        }
        #endregion


    }
}
