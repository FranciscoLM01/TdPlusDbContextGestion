using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OrdenTransferenciaEstadoConfiguration : IEntityTypeConfiguration<OrdenTransferenciaEstado>
    {
        public void Configure(EntityTypeBuilder<OrdenTransferenciaEstado> entity)
        {
            entity.HasKey(e => e.nIdOrdenTransferenciaEstado).HasName("PK_OrdenTransferenciaEstado");

            entity.Property(e => e.nIdOrdenTransferenciaEstado).UseIdentityColumn();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(255);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrdenTransferenciaEstado> entity);
    }
}
