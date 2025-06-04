using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class CuentaConcentradoraConfiguration : IEntityTypeConfiguration<CuentaConcentradora>
    {
        public void Configure(EntityTypeBuilder<CuentaConcentradora> entity)
        {
            entity.HasKey(e => e.nIdCuentaConcentradora).HasName("PK_CuentaConcentradora");

            entity.Property(e => e.nIdCuentaConcentradora).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla tiene el propósito de almacenar las cuentas de los participantes indirectos y las cuentas de los clientes de los participantes indirectos."));

            entity.HasIndex(e => e.nClaveTipoCuenta, "fk_CuentaConcentradora_TipoCuenta");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nSaldo).HasPrecision(18, 2);

            entity.Property(e => e.sAlias)
            .IsRequired()
            .HasMaxLength(100)
            .HasComment("Esta columna corresponde al identificador (alias) de una cuenta concentradora. Por ejemplo: cuantacontradoraclienteindirecto1 Producto");

            entity.HasOne(d => d.nClaveTipoCuentaNavigation).WithMany(p => p.CuentaConcentradora)
            .HasForeignKey(d => d.nClaveTipoCuenta)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_CuentaConcentradora_TipoCuenta");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CuentaConcentradora> entity);
    }
}
