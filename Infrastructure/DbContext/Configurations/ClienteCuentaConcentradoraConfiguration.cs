using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ClienteCuentaConcentradoraConfiguration : IEntityTypeConfiguration<ClienteCuentaConcentradora>
    {
        public void Configure(EntityTypeBuilder<ClienteCuentaConcentradora> entity)
        {
            entity.HasKey(e => new { e.nIdCliente, e.nIdCuentaConcentradora, e.bActivo });

            entity.HasIndex(e => e.nIdCuentaConcentradora, "fk_ClienteIndiCuentaConcentradora_CuentaConcentradora");

            entity.HasIndex(e => new { e.nIdCliente, e.nIdCuentaConcentradora, e.bActivo }, "unq_ClienteIndiCuentaConcentradora").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.nIdClienteNavigation).WithMany()
            .HasForeignKey(d => d.nIdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ClienteIndiCuentaConcentradora_ClienteIndi");

            entity.HasOne(d => d.nIdCuentaConcentradoraNavigation).WithMany()
            .HasForeignKey(d => d.nIdCuentaConcentradora)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ClienteIndiCuentaConcentradora_CuentaConcentradora");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ClienteCuentaConcentradora> entity);
    }
}
