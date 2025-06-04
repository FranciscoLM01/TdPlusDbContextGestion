using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SolicitudSeccionConfiguration : IEntityTypeConfiguration<SolicitudSeccion>
    {
        public void Configure(EntityTypeBuilder<SolicitudSeccion> entity)
        {
            entity.HasKey(e => new { e.nIdSolicitud, e.nIdSeccion });

            entity.HasIndex(e => e.nIdSeccion, "fk_SolicitudSeccion_Seccion");

            entity.HasIndex(e => e.nIdSolicitud, "fk_SolicitudSeccion_SolicitudN");

            entity.HasOne(d => d.nIdSeccionNavigation).WithMany()
            .HasForeignKey(d => d.nIdSeccion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SolicitudSeccion_Seccion");

            entity.HasOne(d => d.nIdSolicitudNavigation).WithMany()
            .HasForeignKey(d => d.nIdSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SolicitudSeccion_SolicitudN");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SolicitudSeccion> entity);
    }
}
