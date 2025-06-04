using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OpcionMenuJerarquicaConfiguration : IEntityTypeConfiguration<OpcionMenuJerarquica>
    {
        public void Configure(EntityTypeBuilder<OpcionMenuJerarquica> entity)
        {
            entity.HasKey(e => new { e.nIdOpcionMenuPadre, e.nIdOpcionMenuHija });

            entity.HasIndex(e => e.nIdOpcionMenuPadre, "fk_OpcionMenuJerarquica_OpcionMenu");

            entity.HasIndex(e => e.nIdOpcionMenuHija, "fk_OpcionMenuJerarquica_OpcionMenu_0");

            entity.HasOne(d => d.nIdOpcionMenuHijaNavigation).WithMany()
            .HasForeignKey(d => d.nIdOpcionMenuHija)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_OpcionMenuJerarquica_OpcionMenu_0");

            entity.HasOne(d => d.nIdOpcionMenuPadreNavigation).WithMany()
            .HasForeignKey(d => d.nIdOpcionMenuPadre)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_OpcionMenuJerarquica_OpcionMenu");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OpcionMenuJerarquica> entity);
    }
}
