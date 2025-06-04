using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;
    
namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SolicitudConfiguration : IEntityTypeConfiguration<Solicitud>
    {
        public void Configure(EntityTypeBuilder<Solicitud> entity)
        {
            entity.HasKey(e => e.nIdSolicitud).HasName("PK_Solicitud");

            entity.Property(e => e.nIdSolicitud).UseIdentityColumn();

            entity.HasIndex(e => e.nIdProspecto, "fk_SolicitudN_ProspectoN");

            entity.HasIndex(e => e.nIdSolicitudEstado, "fk_SolicitudN_SolicitudEstado");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.dFechaAprobacion).HasColumnType("datetime");

            entity.Property(e => e.sObservaciones).HasMaxLength(100);

            entity.HasOne(d => d.nIdProspectoNavigation).WithMany(p => p.Solicitud)
                .HasForeignKey(d => d.nIdProspecto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SolicitudN_ProspectoN");

            entity.HasOne(d => d.nIdSolicitudEstadoNavigation).WithMany(p => p.Solicitud)
                .HasForeignKey(d => d.nIdSolicitudEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SolicitudN_SolicitudEstado");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Solicitud> entity);
    }
}
