using NLog;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MF_Modelo
{
    [Table("Cuenta_Abono_Respuesta")]
    public class Banco
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        static string conStr = ConfigurationManager.ConnectionStrings["SPEIContext"].ConnectionString;

        #region Miembros
        private int _Banco_Id;
        private string _Banco_Dsc;
        private string _Banco_Dsc_Corta;
        private string _Banco_Clave_CNBV;
        //private bool _Banco_Opera_Digito;
        private string _Banco_Clave_Financiera;
        private string _Banco_Cuenta_Contable;
        private bool _Banco_Habilitado;
        private bool _Banco_Permite_ModCtaCientes;
        private bool _Banco_Certifica_CuentaClientes;
        private bool _Banco_GeneraLayout_CertificacionCta;
        private bool _Banco_ConfirmaLayout_CertificacionCta;
        private int _Banco_Longitud_Cuenta;
        private bool _Banco_Maneja_Domiciliacion;
        private bool _Banco_RequiereAltaBaja_Domiciliacion;
        private int _Banco_Clave_Banxico;
        #endregion

        #region Propiedades
        public int Banco_Id
        {
            get { return _Banco_Id; }
            set { _Banco_Id = value; }
        }
        public string Banco_Dsc
        {
            get { return _Banco_Dsc; }
            set { _Banco_Dsc = value; }
        }
        public string Banco_Dsc_Corta
        {
            get { return _Banco_Dsc_Corta; }
            set { _Banco_Dsc_Corta = value; }
        }
        public string Banco_Clave_CNBV
        {
            get { return _Banco_Clave_CNBV; }
            set { _Banco_Clave_CNBV = value; }
        }
        public string Banco_Clave_Financiera
        {
            get { return _Banco_Clave_Financiera; }
            set { _Banco_Clave_Financiera = value; }
        }
        public string Banco_Cuenta_Contable
        {
            get { return _Banco_Cuenta_Contable; }
            set { _Banco_Cuenta_Contable = value; }
        }
        public bool Banco_Habilitado
        {
            get { return _Banco_Habilitado; }
            set { _Banco_Habilitado = value; }
        }
        public bool Banco_Permite_ModCtaCientes
        {
            get { return _Banco_Permite_ModCtaCientes; }
            set { _Banco_Permite_ModCtaCientes = value; }
        }
        public bool Banco_Certifica_CuentaClientes
        {
            get { return _Banco_Certifica_CuentaClientes; }
            set { _Banco_Certifica_CuentaClientes = value; }
        }
        public bool Banco_GeneraLayout_CertificacionCta
        {
            get { return _Banco_GeneraLayout_CertificacionCta; }
            set { _Banco_GeneraLayout_CertificacionCta = value; }
        }
        public bool Banco_ConfirmaLayout_CertificacionCta
        {
            get { return _Banco_ConfirmaLayout_CertificacionCta; }
            set { _Banco_ConfirmaLayout_CertificacionCta = value; }
        }
        public int Banco_Longitud_Cuenta
        {
            get { return _Banco_Longitud_Cuenta; }
            set { _Banco_Longitud_Cuenta = value; }
        }
        public bool Banco_Maneja_Domiciliacion
        {
            get { return _Banco_Maneja_Domiciliacion; }
            set { _Banco_Maneja_Domiciliacion = value; }
        }
        public bool Banco_RequiereAltaBaja_Domiciliacion
        {
            get { return _Banco_RequiereAltaBaja_Domiciliacion; }
            set { _Banco_RequiereAltaBaja_Domiciliacion = value; }
        }
        public int Banco_Clave_Banxico
        {
            get { return _Banco_Clave_Banxico; }
            set { _Banco_Clave_Banxico = value; }
        }
        #endregion

        #region Constructor
        public Banco() { }
        #endregion

        #region Propiedades

        // CRUD
        // Create - Read - Update - Delete
        // Agregar - Leer - Actualizar - Borrar

        public void Agrega(string banco_Clave_CNBV, string banco_Dsc_Corta) 
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand(
                        "[SPEI].[dbo].[sp_i_AgregaRespuestaAbono]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Banco_Dsc_Corta", banco_Dsc_Corta);
                    cmd.Parameters.AddWithValue("@Banco_Clave_CNBV", banco_Clave_CNBV);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error Banco/Agrega");
            }
        }

        public void Actualiza() { }
        #endregion




    }
}
