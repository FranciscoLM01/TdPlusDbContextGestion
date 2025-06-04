using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ProspectoResponsableSistemaConfiguration : IEntityTypeConfiguration<ProspectoResponsableSistema>
    {
        public void Configure(EntityTypeBuilder<ProspectoResponsableSistema> entity)
        {
            entity.HasKey(e => e.sCorreoElectronico);

            entity.HasIndex(e => e.nIdSolicitud, "fk_ProspectoPerfiles_SolicitudN_1");

            entity.HasIndex(e => e.sCorreoElectronico, "unq_ProspectoPerfiles_1").IsUnique();

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sApellidoMaterno)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sApellidoPaterno)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sCorreoElectronico)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.sExtension)
            .IsRequired()
            .HasMaxLength(5);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sTelefono)
            .IsRequired()
            .HasMaxLength(10);

            entity.HasOne(d => d.nIdSolicitudNavigation).WithMany()
            .HasForeignKey(d => d.nIdSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoPerfiles_SolicitudN_1");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProspectoResponsableSistema> entity);
    }
}
