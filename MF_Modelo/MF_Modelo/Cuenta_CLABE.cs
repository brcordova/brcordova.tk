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
        private static readonly SPEIContext db = new SPEIContext();

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

        #region Constructor
        public Cuenta_CLABE() { }
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
