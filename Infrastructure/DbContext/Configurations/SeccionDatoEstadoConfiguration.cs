using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SeccionDatoEstadoConfiguration : IEntityTypeConfiguration<SeccionDatoEstado>
    {
        public void Configure(EntityTypeBuilder<SeccionDatoEstado> entity)
        {
            entity.HasKey(e => e.nIdSeccionDatoEstado).HasName("PK_SeccionDatoEstado");

            entity.Property(e => e.nIdSeccionDatoEstado).UseIdentityColumn();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(100);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SeccionDatoEstado> entity);
    }
}
