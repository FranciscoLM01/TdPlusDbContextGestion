using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SolicitudConfidencialidadConfiguration : IEntityTypeConfiguration<SolicitudConfidencialidad>
    {
        public void Configure(EntityTypeBuilder<SolicitudConfidencialidad> entity)
        {
            entity.HasKey(e => e.nIdSeccion).HasName("PK_SolicitudConfidencialidad");

            entity.Property(e => e.nIdSeccion).UseIdentityColumn();

            entity.HasIndex(e => e.nIdSolicitud, "fk_SolicitudConfidencialidad_Solicitud");

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

            entity.HasOne(d => d.nIdSolicitudNavigation).WithMany(p => p.SolicitudConfidencialidad)
            .HasForeignKey(d => d.nIdSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SolicitudConfidencialidad_Solicitud");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SolicitudConfidencialidad> entity);
    }
}
