using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using NLog;

namespace MF_Modelo
{
    public partial class BancoBL :Banco
    {
        private static readonly SPEIContext db = new SPEIContext();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();


        #region Métodos

        // CRUD
        // Create - Read - Update - Delete
        // Agregar - Leer - Actualizar - Borrar

        public void Agregar()
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
                log.Error(ex, "BancoBL/Agrega");
                //throw new Exception(ex.Message);
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

        public static void Actualizar(Banco banco)
        {
            using (SPEIContext context = new SPEIContext())
            {
                context.Banco.Attach(banco);
                var registro1 = context.Entry(banco);
                registro1.Property(b => b.Banco_Clave_Banxico).IsModified = true;
                context.SaveChanges();
            }
        }

        public Banco Leer(int id)
        {
            return db.Banco.Find(id);
        }

        public void Borrar(int id)
        {
            var registro = (from b in db.Banco
                            where b.Banco_Id == id
                            select b).SingleOrDefault();
            db.Banco.Remove(registro);
            db.SaveChanges();
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

        public List<Banco> List ()
        {
            //List<Banco> lista =null;
            // var lstBanco =  ( from b in db.Banco
            //                       select b).ToList();
             return (from b in db.Banco
                     select b).ToList();
        }

        #endregion

    }
}
