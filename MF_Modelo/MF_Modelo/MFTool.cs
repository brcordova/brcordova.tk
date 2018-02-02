using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MF_Modelo
{
    public class MFTool
    {

        private static readonly SPEIContext db = new SPEIContext();

        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        private static string strConStrSPEI = ConfigurationManager.ConnectionStrings["SPEIContext"].ConnectionString;

        private static string strConStrSIIF = ConfigurationManager.ConnectionStrings["SIIFContext"].ConnectionString;

        private static string strConString = ConfigurationManager.ConnectionStrings["SIIF"].ConnectionString;

        /// <summary>
        /// Devuelve el digito verificador del contrato.
        /// En caso de no existir en la tabla se crea el registro
        /// con el banco STP 646
        /// </summary>
        /// <param name="strContratoId">Id. del contrato</param>
        /// <returns>Devuelve el dígito verificador</returns>
        public string devuelveDV(string strContratoId)
        {
            string res = String.Empty;
            string strSql = String.Empty;
            strSql = "SPEI.dbo.sp_In_AgregaCuentaBancaria";

            try
            {
                using (SqlConnection conn = new SqlConnection(strConStrSPEI))
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(@"@pstrContratoId", strContratoId);
                    cmd.Parameters.Add("@pintDV", SqlDbType.Int).Direction = ParameterDirection.Output;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.ExecuteNonQuery();

                    res = cmd.Parameters["@pintDV"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error toolsMF/devuelveDV");
            }

            return res;
        }


        /// <summary>
        /// Obtenemos el nivel del usuario que esta registrado
        /// </summary>
        /// <param name="strUsr">Nombre de usuario</param>
        /// <param name="strNiveles">Rango de niveles autorizados.</param>
        /// <returns>Nivel al que pertenece el usuario.</returns>
        public string devuelveNivel(string strUsr)
        {
            string res = String.Empty;

            string strSql = "SELECT Nivel_Id FROM SIIFMF01.dbo.Usuario AS U WHERE U.Usuario_Inactivo = 0 AND U.Usuario_Id = '" + strUsr + "' AND (";
            string strAndNivel = String.Empty;


            String[] strNivel = ConfigurationManager.AppSettings["NivelesAutorizados"].Split(',');

            foreach (string item in strNivel)
            {
                strAndNivel += " U.Nivel_Id = " + item + " OR ";
            }

            strAndNivel = strAndNivel.Substring( 0, strAndNivel.Length - 3);

            strSql += strAndNivel + ");";

            try
            {
                using (SqlConnection conn = new SqlConnection(strConStrSIIF))
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@strNiveles", strNiveles);
                    //cmd.Parameters.AddWithValue("@strUser", strUsr);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            res = lector[0].ToString();
                        }
                    }
                    else
                        res = "0";
                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error toolsMF/devuelveNivel");
                res = "err";
            }

            return res;
        }

        public DataSet obtenerOrdenesPendientes (DateTime dtFecha)
        {
            DataSet lector = new DataSet();
            DateTime dtFechaMod = new DateTime(dtFecha.Year,dtFecha.Month,dtFecha.Day);
            try
            {
                using (SqlConnection conn = new SqlConnection(strConStrSIIF))
                {
                    string strSql = "SIIFMF01.dbo.sp_TE_Se_ConexionAut_OrdenesPendientes";

                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@psintTipoOpeCompra",5);
                    cmd.Parameters.AddWithValue("@psintTipoIngEgresoCargo",5);
                    cmd.Parameters.AddWithValue("@psintStsOrdenCargada",5);

                    cmd.Parameters.AddWithValue("@psintStsOrdenAten",20);
                    cmd.Parameters.AddWithValue("@psintTpoMdoIdTeso",20);
                    
                    cmd.Parameters.AddWithValue("@psintTpoMdoIdSocInv",15);
                    
                    cmd.Parameters.AddWithValue("@psintDivisaIdMN",5);
                    
                    cmd.Parameters.AddWithValue("@psintBancoId",0);
                    cmd.Parameters.AddWithValue("@ptintDigito",1);

                    cmd.Parameters.Add(new SqlParameter("@pdtmFecha", SqlDbType.SmallDateTime) { Value = dtFechaMod });
                    cmd.Parameters.Add(new SqlParameter("@pdtmFechaDeposito", SqlDbType.SmallDateTime) { Value = dtFechaMod });

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(lector);

                }
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error MFTools/obtenerOrdenesPendientes");
            }

            return lector;
        }

    }
}
