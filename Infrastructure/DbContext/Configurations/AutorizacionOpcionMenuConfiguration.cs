using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities; 

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class AutorizacionOpcionMenuConfiguration : IEntityTypeConfiguration<AutorizacionOpcionMenu>
    {
        public void Configure(EntityTypeBuilder<AutorizacionOpcionMenu> entity)
        {
            entity.HasKey(e => new { e.nIdOpcionMenu, e.nIdPerfil });

            entity.HasIndex(e => e.nIdOpcionMenu, "fk_AutorizacionOpcionMenu_OpcionMenu");

            entity.HasIndex(e => e.nIdPerfil, "fk_AutorizacionOpcionMenu_Perfil");

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.nIdOpcionMenuNavigation).WithMany()
            .HasForeignKey(d => d.nIdOpcionMenu)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_AutorizacionOpcionMenu_OpcionMenu");

            entity.HasOne(d => d.nIdPerfilNavigation).WithMany()
            .HasForeignKey(d => d.nIdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_AutorizacionOpcionMenu_Perfil");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AutorizacionOpcionMenu> entity);
    }
}
