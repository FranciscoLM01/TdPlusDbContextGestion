using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ProspectoPerfilesConfiguration : IEntityTypeConfiguration<ProspectoPerfiles>
    {
        public void Configure(EntityTypeBuilder<ProspectoPerfiles> entity)
        {
            entity.HasKey(e => e.sCorreoElectronico);

            entity.HasIndex(e => e.nIdPerfil, "fk_ProspectoPerfiles_Perfil");

            entity.HasIndex(e => e.nIdSolicitud, "fk_ProspectoPerfiles_SolicitudN");

            entity.HasIndex(e => e.sCorreoElectronico, "unq_ProspectoPerfiles").IsUnique();

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.dFechaNacimiento).HasColumnType("datetime");

            entity.Property(e => e.sApellidoMaterno)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sApellidoPaterno)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sCorreoElectronico)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sTelefono)
            .IsRequired()
            .HasMaxLength(10);

            entity.HasOne(d => d.nIdPerfilNavigation).WithMany()
            .HasForeignKey(d => d.nIdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoPerfiles_Perfil");

            entity.HasOne(d => d.nIdSolicitudNavigation).WithMany()
            .HasForeignKey(d => d.nIdSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ProspectoPerfiles_SolicitudN");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProspectoPerfiles> entity);
    }
}
