using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ProspectoDocumentoConfiguration : IEntityTypeConfiguration<ProspectoDocumento>
    {
        public void Configure(EntityTypeBuilder<ProspectoDocumento> entity)
        {
            entity.HasKey(e => new { e.nIdSolicitud, e.nIdSeccionDato, e.nIdSeccionDatoEstado });

            entity.HasIndex(e => e.nIdSeccionDato, "fk_ProspectoDocumentoN_SeccionDato");

            entity.HasIndex(e => e.nIdSeccionDatoEstado, "fk_ProspectoDocumentoN_SeccionDatoEstado");

            entity.HasIndex(e => e.nIdSolicitud, "fk_ProspectoDocumentoN_SolicitudN");

            entity.Property(e => e.Path)
            .IsRequired()
            .HasMaxLength(100);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDato)
            .IsRequired()
            .HasMaxLength(255)
            .HasComment("Esta columna corresponde al valor o data del documento");

            entity.Property(e => e.sKey)
            .IsRequired()
            .HasMaxLength(100);

            entity.HasOne(d => d.nIdSeccionDatoNavigation).WithMany()
            .HasForeignKey(d => d.nIdSeccionDato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoDocumentoN_SeccionDato");

            entity.HasOne(d => d.nIdSeccionDatoEstadoNavigation).WithMany()
            .HasForeignKey(d => d.nIdSeccionDatoEstado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoDocumentoN_SeccionDatoEstado");

            entity.HasOne(d => d.nIdSolicitudNavigation).WithMany()
            .HasForeignKey(d => d.nIdSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoDocumentoN_SolicitudN");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProspectoDocumento> entity);
    }
}
