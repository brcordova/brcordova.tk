namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sts_Abono
    {
        public int Id { get; set; }

        public int Sts_Abono_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Sts_Abono_Dsc { get; set; }

        [Required]
        [StringLength(15)]
        public string Sts_Abono_Dsc_Corta { get; set; }

        public bool Sts_Abono_Activo { get; set; }
    }
}
