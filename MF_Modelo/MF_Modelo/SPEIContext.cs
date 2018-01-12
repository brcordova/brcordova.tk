namespace MF_Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SPEIContext : DbContext
    {
        public SPEIContext()
            : base("name=SPEIContext")
        {
        }

        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Cuenta_Abono> Cuenta_Abono { get; set; }
        public virtual DbSet<Cuenta_Abono_Respuesta> Cuenta_Abono_Respuesta { get; set; }
        public virtual DbSet<Cuenta_CLABE> Cuenta_CLABE { get; set; }
        public virtual DbSet<Cuenta_OrdenPago> Cuenta_OrdenPago { get; set; }
        public virtual DbSet<Sts_Abono> Sts_Abono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bitacora>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_claveRastreo)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_nombreOrdenante)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_cuentaOrdenante)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_rfcCurpOrdenante)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_nombreBeneficiario)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_cuentaBeneficiario)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_rfcCurpBeneficiario)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_conceptoPago)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_empresa)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono>()
                .Property(e => e.Cuenta_Abono_claveRastreoDev)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono_Respuesta>()
                .Property(e => e.Cuenta_Abono_Respuesta_empresa)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono_Respuesta>()
                .Property(e => e.Cuenta_Abono_Respuesta_medioEntrega)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono_Respuesta>()
                .Property(e => e.Cuenta_Abono_Respuesta_folioOrigen)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_Abono_Respuesta>()
                .Property(e => e.Cuenta_Abono_Respuesta_rastreoDevolucion)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_CLABE>()
                .Property(e => e.Cuenta_Clabe_Contrato_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_CLABE>()
                .Property(e => e.Cuenta_Clabe_CLABE)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_Empresa)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_Clave_Rastreo)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_NombreBeneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_Tipo_Cuenta_Beneficiario)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_Cuenta_Beneficiario)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_RFC_CURP)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_Concepto_Pago)
                .IsFixedLength();

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_Email_Beneficiario)
                .IsFixedLength();

            modelBuilder.Entity<Sts_Abono>()
                .Property(e => e.Sts_Abono_Dsc)
                .IsFixedLength();

            modelBuilder.Entity<Sts_Abono>()
                .Property(e => e.Sts_Abono_Dsc_Corta)
                .IsFixedLength();
        }
    }
}
