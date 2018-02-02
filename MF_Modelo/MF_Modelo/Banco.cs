namespace MF_Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Banco")]
    public partial class Banco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Banco_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Banco_Dsc { get; set; }

        [Required]
        [StringLength(15)]
        public string Banco_Dsc_Corta { get; set; }

        public int Banco_Clave_CNBV { get; set; }

        public bool Banco_Opera_Digito { get; set; }

        [Required]
        [StringLength(10)]
        public string Banco_Clave_Financiera { get; set; }

        [Required]
        [StringLength(4)]
        public string Banco_Cuenta_Contable { get; set; }

        public bool Banco_Habilitado { get; set; }

        public bool Banco_Permite_ModCtaCientes { get; set; }

        public bool Banco_Certifica_CuentaClientes { get; set; }

        public bool Banco_GeneraLayout_CertificacionCta { get; set; }

        public bool Banco_ConfirmaLayout_CertificacionCta { get; set; }

        public short Banco_Longitud_Cuenta { get; set; }

        public bool Banco_Maneja_Domiciliacion { get; set; }

        public bool Banco_RequiereAltaBaja_Domiciliacion { get; set; }

        public int Banco_Clave_Banxico { get; set; }

    }
}
