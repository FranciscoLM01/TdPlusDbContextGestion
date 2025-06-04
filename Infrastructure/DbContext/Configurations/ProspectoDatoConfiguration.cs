using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ProspectoDatoConfiguration : IEntityTypeConfiguration<ProspectoDato>
    {
        public void Configure(EntityTypeBuilder<ProspectoDato> entity)
        {
            entity.HasKey(e => new { e.nIdSolicitud, e.nIdSeccionDato, e.nIdSeccionDatoEstado });

            entity.HasIndex(e => e.nIdSeccionDato, "fk_ProspectoDatoN_SeccionDato");

            entity.HasIndex(e => e.nIdSeccionDatoEstado, "fk_ProspectoDatoN_SeccionDatoEstado");

            entity.HasIndex(e => e.nIdSolicitud, "fk_ProspectoDatoN_SolicitudN");

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDato)
            .IsRequired()
            .HasMaxLength(255);

            entity.HasOne(d => d.nIdSeccionDatoNavigation).WithMany()
            .HasForeignKey(d => d.nIdSeccionDato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoDatoN_SeccionDato");

            entity.HasOne(d => d.nIdSeccionDatoEstadoNavigation).WithMany()
            .HasForeignKey(d => d.nIdSeccionDatoEstado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoDatoN_SeccionDatoEstado");

            entity.HasOne(d => d.nIdSolicitudNavigation).WithMany()
            .HasForeignKey(d => d.nIdSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoDatoN_SolicitudN");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProspectoDato> entity);
    }
}
