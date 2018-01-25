namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using NLog;

    public partial class Sts_Abono
    {


        private static readonly SPEIContext db = new SPEIContext();
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        #region Propiedades
        public int Id { get; set; }

        public int Sts_Abono_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Sts_Abono_Dsc { get; set; }

        [Required]
        [StringLength(15)]
        public string Sts_Abono_Dsc_Corta { get; set; }

        public bool Sts_Abono_Activo { get; set; }
        #endregion

        public Sts_Abono DevuelveId(int intId = 0)
        {
            Sts_Abono estatus = null;
            if (intId > 0)
            {
                estatus = (from sa in db.Sts_Abono
                                     where sa.Sts_Abono_Id == intId
                                     select sa).FirstOrDefault();
            }
            return estatus;
        }
    }
}
