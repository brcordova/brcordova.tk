namespace MF_Modelo
{

    using NLog;
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class Cuenta_Abono_Conciliacion
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        static string conStr = ConfigurationManager.ConnectionStrings["SPEIContext"].ConnectionString;

        #region Miembros
        private int _psintBancoId;
        private string _pstrCuentaId;
        private int _pintConciliacionPendienteId;
        private DateTime _pdtmConciliacionPendienteFecha;
        private string _pstrConciliacionPendienteDsc;
        private decimal _pfltConciliacionPendienteImporte;
        private int _psintConciliacionPendienteIngEgr;
        private string _pstrUsuarioId;
        private string _pstrConciliacionPendienteReferencia;
        private string _pstrConciliacionPendienteMovtoBanco;
        private string _pstrConciliacionPendienteFechaImp;
        private bool _pbitConciliacionPendienteAut;
        private string _pstrConciliacionPendienteObservaciones;
        private string _pstrTipoLoquidacionBancoId;
        private string _pstrConciliacionPendienteCheque;
        private int _Consecutivo;
        #endregion

        #region Propiedades
        public int psintBancoId
        {
            get { return _psintBancoId; }
            set { _psintBancoId = value; }
        }
        public string pstrCuentaId
        {
            get { return _pstrCuentaId; }
            set { _pstrCuentaId = value; }
        }
        public int pintConciliacionPendienteId
        {
            get { return _pintConciliacionPendienteId; }
            set { _pintConciliacionPendienteId = value; }
        }
        public DateTime pdtmConciliacionPendienteFecha
        {
            get { return _pdtmConciliacionPendienteFecha; }
            set { _pdtmConciliacionPendienteFecha = value; }
        }
        public string pstrConciliacionPendienteDsc
        {
            get { return _pstrConciliacionPendienteDsc; }
            set { _pstrConciliacionPendienteDsc = value; }
        }
        public decimal pfltConciliacionPendienteImporte
        {
            get { return _pfltConciliacionPendienteImporte; }
            set { _pfltConciliacionPendienteImporte = value; }
        }
        public int psintConciliacionPendienteIngEgr
        {
            get { return _psintConciliacionPendienteIngEgr; }
            set { _psintConciliacionPendienteIngEgr = value; }
        }
        public string pstrUsuarioId
        {
            get { return _pstrUsuarioId; }
            set { _pstrUsuarioId = value; }
        }
        public string pstrConciliacionPendienteReferencia
        {
            get { return _pstrConciliacionPendienteReferencia; }
            set { _pstrConciliacionPendienteReferencia = value; }
        }
        public string pstrConciliacionPendienteMovtoBanco
        {
            get { return _pstrConciliacionPendienteMovtoBanco; }
            set { _pstrConciliacionPendienteMovtoBanco = value; }
        }
        public string pstrConciliacionPendienteFechaImp
        {
            get { return _pstrConciliacionPendienteFechaImp; }
            set { _pstrConciliacionPendienteFechaImp = value; }
        }
        public bool pbitConciliacionPendienteAut
        {
            get { return _pbitConciliacionPendienteAut; }
            set { _pbitConciliacionPendienteAut = value; }
        }
        public string pstrConciliacionPendienteObservaciones
        {
            get { return _pstrConciliacionPendienteObservaciones; }
            set { _pstrConciliacionPendienteObservaciones = value; }
        }
        public string pstrTipoLoquidacionBancoId
        {
            get { return _pstrTipoLoquidacionBancoId; }
            set { _pstrTipoLoquidacionBancoId = value; }
        }
        public string pstrConciliacionPendienteCheque
        {
            get { return _pstrConciliacionPendienteCheque; }
            set { _pstrConciliacionPendienteCheque = value; }
        }
        public int Consecutivo
        {
            get { return _Consecutivo; }
            set { _Consecutivo = value; }
        }
        #endregion

        #region Constructor
        public Cuenta_Abono_Conciliacion() { }
        #endregion

        #region Métodos
        public bool RegistraConciliacion()
        {
            bool res = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    // Actualizo el último número de Folio
                    string sqlCmdFolio = " SET DATEFORMAT 'dmy'  UPDATE SIIFMF01.dbo.Folio SET Folio_Id = Folio_Id + 1 WHERE Tipo_Folio_Id = 310 AND Tipo_Mercado_Id = 20; SELECT Consecutivo = Isnull((Folio_Id),1)  FROM SIIFMF01.dbo.Folio WHERE Tipo_Folio_Id = 310 AND Tipo_Mercado_Id = 20";
                    SqlCommand cmdFolio = new SqlCommand(sqlCmdFolio, conn);
                    cmdFolio.CommandType = CommandType.Text;
                    conn.Open();

                    pintConciliacionPendienteId = (int)cmdFolio.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand(
                        "SIIFMF01.dbo.sp_TE_In_Conciliacion_Pendiente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@psintBancoId", Convert.ToInt16(psintBancoId)); //Convert.ToInt16(psintBancoId));
                    cmd.Parameters.AddWithValue("@pstrCuentaId", pstrCuentaId); // pstrCuentaId);
                    cmd.Parameters.AddWithValue("@pintConciliacionPendienteId", pintConciliacionPendienteId);
                    cmd.Parameters.AddWithValue("@pdtmConciliacionPendienteFecha", pdtmConciliacionPendienteFecha);
                    cmd.Parameters.AddWithValue("@pstrConciliacionPendienteDsc", pstrConciliacionPendienteDsc);
                    cmd.Parameters.AddWithValue("@pfltConciliacionPendienteImporte", pfltConciliacionPendienteImporte);
                    cmd.Parameters.AddWithValue("@psintConciliacionPendienteIngEgr", psintConciliacionPendienteIngEgr);
                    cmd.Parameters.AddWithValue("@pstrUsuarioId", pstrUsuarioId);
                    cmd.Parameters.AddWithValue("@pstrConciliacionPendienteReferencia", pstrConciliacionPendienteReferencia);
                    cmd.Parameters.AddWithValue("@pstrConciliacionPendienteMovtoBanco", pstrConciliacionPendienteMovtoBanco);
                    cmd.Parameters.AddWithValue("@pdtmConciliacionPendienteFechaImp", DateTime.Now);
                    cmd.Parameters.AddWithValue("@pbitConciliacionPendienteAut", pbitConciliacionPendienteAut);
                    cmd.Parameters.AddWithValue("@pstrConciliacionPendienteObservaciones", pstrConciliacionPendienteObservaciones);
                    cmd.Parameters.AddWithValue("@psintTipoLiquidacionBancoId", 9999);
                    cmd.Parameters.AddWithValue("@pstrConciliacionPendienteCheque", "");

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error Cuenta_Abono_Conciliacion/RegistraConciliacion");
                res = false;

            }

            return res;
        }
        #endregion












    }
}
