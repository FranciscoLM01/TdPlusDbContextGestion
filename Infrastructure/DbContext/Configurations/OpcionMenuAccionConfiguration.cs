using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OpcionMenuAccionConfiguration : IEntityTypeConfiguration<OpcionMenuAccion>
    {
        public void Configure(EntityTypeBuilder<OpcionMenuAccion> entity)
        {
            entity.HasKey(e => e.nIdOpcionMenuAccion).HasName("PK_OpcionMenuAccion");

            entity.Property(e => e.nIdOpcionMenuAccion).UseIdentityColumn();

            entity.HasIndex(e => new { e.nIdOpcionMenu, e.nIdAccion }, "unq_OpcionMenuAccion").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(e => e.sNombre)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.nIdOpcionMenuNavigation).WithMany(p => p.OpcionMenuAccion)
                .HasForeignKey(d => d.nIdOpcionMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_OpcionMenuAccion_OpcionMenu");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OpcionMenuAccion> entity);
    }
}
