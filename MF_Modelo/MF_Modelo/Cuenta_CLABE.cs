namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuenta_CLABE
    {
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
    }
}
