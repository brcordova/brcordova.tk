using NLog;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MF_Modelo
{
    public partial class toolsMF
    {
        private static string strConStrSPEI = ConfigurationManager.ConnectionStrings["SPEIContext"].ConnectionString;

        string strConStrSIIF = ConfigurationManager.ConnectionStrings["SIIFContext"].ConnectionString;

        private static readonly SPEIContext db = new SPEIContext();
        
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

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
            strSql = "SIIFMF01.dbo.sp_In_AgregaCuentaBancaria";

            try
            {
                using (SqlConnection conn = new SqlConnection(strConStrSIIF))
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
        public string devuelveNivel(string strUsr, string strNiveles)
        {
            string res = String.Empty;

            string strSql = "SELECT Nivel_Id FROM SIIFMF01.dbo.Usuario AS U WHERE U.Usuario_Inactivo = 0 AND U.Nivel_Id in (@strNiveles) AND U.Usuario_Id = @strUser";

            try
            {
                using (SqlConnection conn = new SqlConnection(strConStrSIIF))
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@strNiveles", strNiveles);
                    cmd.Parameters.AddWithValue("@strUser", strUsr);
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
        
    }
}
