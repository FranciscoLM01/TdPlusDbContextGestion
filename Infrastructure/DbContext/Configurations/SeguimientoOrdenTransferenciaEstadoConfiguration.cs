using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SeguimientoOrdenTransferenciaEstadoConfiguration : IEntityTypeConfiguration<SeguimientoOrdenTransferenciaEstado>
    {
        public void Configure(EntityTypeBuilder<SeguimientoOrdenTransferenciaEstado> entity)
        {
            //entity.HasKey(e => new { e.nIdOrdenTransferencia, e.nIdOrdenTransferenciaEstado, e.nIdUsuario, e.dFecRegistro });

            entity.HasKey(e => e.nIdSeguimientoOrdenTransferenciaEstado).HasName("PK_SeguimientoOrdenTransferenciaEstado");

            entity.HasIndex(e => e.nIdOrdenTransferencia, "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferencia");

            entity.HasIndex(e => e.nIdOrdenTransferenciaEstado, "fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferenciaEstado");

            entity.HasIndex(e => e.nIdUsuario, "fk_SeguimientoOrdenTransferenciaEstado_Usuario");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime(6)");

            entity.Property(e => e.nIdUsuario).HasComment("El identificar único del usuario actual que afectaría el nuevo estado o status de la orden de transferencia");

            entity.Property(e => e.sMotivo).HasMaxLength(255);

            entity.HasOne(d => d.nIdOrdenTransferenciaNavigation).WithMany()
            .HasForeignKey(d => d.nIdOrdenTransferencia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferencia");

            entity.HasOne(d => d.nIdOrdenTransferenciaEstadoNavigation).WithMany()
            .HasForeignKey(d => d.nIdOrdenTransferenciaEstado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SeguimientoOrdenTransferenciaEstado_OrdenTransferenciaEstado");

            entity.HasOne(d => d.nIdUsuarioNavigation).WithMany()
            .HasForeignKey(d => d.nIdUsuario)
            .HasConstraintName("fk_SeguimientoOrdenTransferenciaEstado_Usuario");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SeguimientoOrdenTransferenciaEstado> entity);
    }
}
