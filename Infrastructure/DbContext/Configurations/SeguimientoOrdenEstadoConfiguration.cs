using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SeguimientoOrdenEstadoConfiguration : IEntityTypeConfiguration<SeguimientoOrdenEstado>
    {
        public void Configure(EntityTypeBuilder<SeguimientoOrdenEstado> entity)
        {
            //entity.HasKey(e => new { e.nIdOrden, e.nIdOrdenEstado, e.nIdUsuario, e.dFecRegistro });

            entity.HasKey(e => e.nIdSeguimientoOrdenEstado).HasName("PK_SeguimientoOrdenEstado");

            entity.HasIndex(e => e.nIdOrden, "fk_SeguimientoOrdenEstado_Orden");

            entity.HasIndex(e => e.nIdOrdenEstado, "fk_SeguimientoOrdenEstado_OrdenEstado");

            entity.HasIndex(e => e.nIdUsuario, "fk_SeguimientoOrdenEstado_Usuario");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime(6)");

            entity.Property(e => e.sMotivo).HasMaxLength(255);

            entity.HasOne(d => d.nIdOrdenNavigation).WithMany()
            .HasForeignKey(d => d.nIdOrden)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SeguimientoOrdenEstado_Orden");

            entity.HasOne(d => d.nIdOrdenEstadoNavigation).WithMany()
            .HasForeignKey(d => d.nIdOrdenEstado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SeguimientoOrdenEstado_OrdenEstado");

            entity.HasOne(d => d.nIdUsuarioNavigation).WithMany()
            .HasForeignKey(d => d.nIdUsuario)
            .HasConstraintName("fk_SeguimientoOrdenEstado_Usuario");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SeguimientoOrdenEstado> entity);
    }
}
