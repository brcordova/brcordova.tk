namespace MF_Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuenta_OrdenPago
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cuenta_OrdenPago_Id_STP { get; set; }

        public DateTime? Cuenta_OrdenPago_FechaOperacion { get; set; }

        public int? Cuenta_OrdenPago_Tipo_Pago { get; set; }

        [Required]
        [StringLength(10)]
        public string Cuenta_OrdenPago_Empresa { get; set; }

        public int? Cuenta_OrdenPago_Institucion_Contraparte { get; set; }

        [Required]
        [StringLength(17)]
        public string Cuenta_OrdenPago_Clave_Rastreo { get; set; }

        public decimal? Cuenta_OrdenPago_Monto { get; set; }

        public decimal? Cuenta_OrdenPago_IVA { get; set; }

        [StringLength(150)]
        public string Cuenta_OrdenPago_NombreBeneficiario { get; set; }

        [StringLength(10)]
        public string Cuenta_OrdenPago_Tipo_Cuenta_Beneficiario { get; set; }

        [StringLength(18)]
        public string Cuenta_OrdenPago_Cuenta_Beneficiario { get; set; }

        [StringLength(18)]
        public string Cuenta_OrdenPago_RFC_CURP { get; set; }

        [StringLength(150)]
        public string Cuenta_OrdenPago_Concepto_Pago { get; set; }

        public int? Cuenta_OrdenPago_ReferenciaNumerica { get; set; }

        [StringLength(60)]
        public string Cuenta_OrdenPago_Email_Beneficiario { get; set; }

        public int? Cuenta_OrdenPago_Institucion_Operante { get; set; }
    }
}
