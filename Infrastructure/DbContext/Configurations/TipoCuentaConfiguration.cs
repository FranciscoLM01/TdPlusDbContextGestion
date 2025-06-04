using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class TipoCuentaConfiguration : IEntityTypeConfiguration<TipoCuenta>
    {
        public void Configure(EntityTypeBuilder<TipoCuenta> entity)
        {
            entity.HasKey(e => e.nClaveTipoCuenta).HasName("PK_TipoCuenta");

            entity.Property(e => e.nClaveTipoCuenta).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla almacenará el catalógo de tipos de cuenta, por ejemplo, si el tipo de cuenta es una CLABE, tarjeta de débito o un teléfono celular."));

            entity.HasIndex(e => e.nClaveTipoCuenta, "unq_TipoCuenta").IsUnique();

            //entity.Property(e => e.nClaveTipoCuenta)
            //.ValueGeneratedNever()
            //.HasComment("Esta columna corresponde a la clave que se le asigna a un item del catalogo de Tipos de cuenta");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento)
            .HasComment("Esta columna corresponde a la fecha y hora de actualización del registro.")
            .HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
            .HasComment("Esta columna corresponde a la fecha y hora de inserción del registro.")
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(100)
            .HasComment("Esta columna corresponde al nombre del tipo de cuenta, por ejemplo, si el tipo de cuenta es CLABE, Número celular, entro otros.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoCuenta> entity);
    }
}
