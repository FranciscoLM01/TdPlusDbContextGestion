using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class CuentaClienteConfiguration : IEntityTypeConfiguration<CuentaCliente>
    {
        public void Configure(EntityTypeBuilder<CuentaCliente> entity)
        {
            entity.HasKey(e => new { e.nIdCliente, e.nClaveTipoCuenta });

            entity.HasIndex(e => e.nClaveTipoCuenta, "fk_CuentaClienteIndirecto_TipoCuenta");

            entity.HasIndex(e => new { e.nIdCliente, e.nClaveTipoCuenta }, "unq_CuentaClienteIndirecto").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sBanco)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.sCuenta).HasMaxLength(20);

            entity.HasOne(d => d.nClaveTipoCuentaNavigation).WithMany()
            .HasForeignKey(d => d.nClaveTipoCuenta)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_CuentaClienteIndirecto_TipoCuenta");

            entity.HasOne(d => d.nIdClienteNavigation).WithMany()
            .HasForeignKey(d => d.nIdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_CuentaCliente_Cliente");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CuentaCliente> entity);
    }
}
