using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class UsuarioPermisoAccionConfiguration : IEntityTypeConfiguration<UsuarioPermisoAccion>
    {
        public void Configure(EntityTypeBuilder<UsuarioPermisoAccion> entity)
        {
            entity.HasKey(e => new { e.nIdOpcionMenuAccion, e.nIdPerfil, e.nIdUsuario });

            entity.HasIndex(e => e.nIdOpcionMenuAccion, "fk_UsuarioPermisoAccion_OpcionMenuAccion");

            entity.HasIndex(e => e.nIdPerfil, "fk_UsuarioPermisoAccion_Perfil");

            entity.HasIndex(e => e.nIdUsuario, "fk_UsuarioPermisoAccion_Usuario");

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.nIdOpcionMenuAccionNavigation).WithMany()
            .HasForeignKey(d => d.nIdOpcionMenuAccion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_UsuarioPermisoAccion_OpcionMenuAccion");

            entity.HasOne(d => d.nIdPerfilNavigation).WithMany()
            .HasForeignKey(d => d.nIdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_UsuarioPermisoAccion_Perfil");

            entity.HasOne(d => d.nIdUsuarioNavigation).WithMany()
            .HasForeignKey(d => d.nIdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_UsuarioPermisoAccion_Usuario");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<UsuarioPermisoAccion> entity);
    }
}
