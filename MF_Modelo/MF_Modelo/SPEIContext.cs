namespace MF_Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Infrastructure;

    public partial class SPEIContext : DbContext
    {
        public SPEIContext()
            : base("name=SPEIContext") { }


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

            modelBuilder.Entity<Cuenta_CLABE>()
                .Property(e => e.Cuenta_Clabe_Contrato_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_OrdenPago>()
                .Property(e => e.Cuenta_OrdenPago_NombreBeneficiario)
                .IsUnicode(false);
        }


        /* 
          
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Cuenta_Abono> Cuenta_Abono { get; set; }
        public virtual DbSet<Cuenta_Abono_Respuesta> Cuenta_Abono_Respuesta { get; set; }
        public virtual DbSet<Cuenta_CLABE> Cuenta_CLABE { get; set; }
        public virtual DbSet<Cuenta_OrdenPago> Cuenta_OrdenPago { get; set; }
        public virtual DbSet<Sts_Abono> Sts_Abono { get; set; } 
         
         */
        
    }
}
