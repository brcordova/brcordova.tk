namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    public partial class Cuenta_CLABE
    {
        SPEIContext db = new SPEIContext();

        #region Propiedades
        public int Id { get; set; }

        public short? Cuenta_Clabe_Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Cuenta_Clabe_Contrato_Id { get; set; }

        [Required]
        [StringLength(18)]
        public string Cuenta_Clabe_CLABE { get; set; }

        public DateTime Cuenta_Clabe_Fecha_Registro { get; set; }

        public bool Cuenta_Clabe_Activo { get; set; }
        #endregion

        #region Métodos
        public bool existeCLABE(string strClabe)
        {
            bool ret = false;
            var res = from clabe in db.Cuenta_CLABE
                      where clabe.Cuenta_Clabe_CLABE == strClabe
                      select clabe;

            if (res.Count() > 0)
                ret = true;

            return ret;
        }

        public bool validaCLABE(string strClabe)
        {
            // 0-2      3 Posiciones Código de STP                      Valor: 646
            // 3-5      3 Posiciones Código de Plaza                    Valor: 180
            // 6-9      4 Posiciones Código de Cliente MAS_FONDOS       Valor: 1457
            // 10-17    7 Posiciones Id del Contrato inicia con cero    Valor: 9999999
            // 18-18    1 Posición   Dígito de control                  Valor: 9
            bool Res = false;

            string strCodSTP = strClabe.Substring(0, 3);
            string strCodPlaza = strClabe.Substring(3, 3);
            string strCodMF = strClabe.Substring(6, 4);
            string strCodCte = strClabe.Substring(10, 7);

            if ((strCodSTP == "646") && (strCodPlaza == "180") && (strCodMF == "1457"))
                Res = true;

            return Res;
        }

        public bool Agregar()
        {
            bool ret = false;

            try
            {
                db.Cuenta_CLABE.Add(this);
                ret = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return ret;
        }
        #endregion	
    }
}
