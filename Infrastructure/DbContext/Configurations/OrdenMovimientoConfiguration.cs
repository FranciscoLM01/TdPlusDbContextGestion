using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OrdenMovimientoConfiguration : IEntityTypeConfiguration<OrdenMovimiento>
    {
        public void Configure(EntityTypeBuilder<OrdenMovimiento> entity)
        {
            //entity.HasKey(e => new { e.nIdOrden, e.nIdMovimiento });

            entity.HasKey(e => e.nIdOrdenMovimiento).HasName("PK_OrdenMovimiento");

            entity
                .ToTable(tb => tb.HasComment("Esta tabla tiene el propósito de almacenar las órdenes y los movimientos correspondientes y saber las afectaciones que van realizando en el saldo del participante"));

            entity.HasIndex(e => e.nIdMovimiento, "fk_OrdenMovimiento_Movimiento");

            entity.HasIndex(e => e.nIdOrden, "fk_OrdenMovimiento_Orden");

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.nIdMovimientoNavigation).WithMany()
            .HasForeignKey(d => d.nIdMovimiento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_OrdenMovimiento_Movimiento");

            entity.HasOne(d => d.nIdOrdenNavigation).WithMany()
            .HasForeignKey(d => d.nIdOrden)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_OrdenMovimiento_Orden");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrdenMovimiento> entity);
    }
}
