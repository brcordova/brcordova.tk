namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLABE")]
    public partial class CLABE
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal id_CLABE { get; set; }

        [Required]
        [StringLength(10)]
        public string Contrato_Id { get; set; }

        [Column("CLABE")]
        [Required]
        [StringLength(18)]
        public string CLABE1 { get; set; }

        public DateTime fechaRegistro { get; set; }
    }
}
