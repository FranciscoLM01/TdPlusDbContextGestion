using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.HasKey(e => e.nIdUsuario).HasName("PK_Usuario");

            entity.Property(e => e.nIdUsuario).UseIdentityColumn();

            entity.HasIndex(e => e.nIdPerfil, "fk_Usuario_Perfil");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

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

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sTelefono)
            .IsRequired()
            .HasMaxLength(12);

            entity.HasOne(d => d.nIdPerfilNavigation).WithMany(p => p.Usuario)
            .HasForeignKey(d => d.nIdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Usuario_Perfil");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Usuario> entity);
    }
}
