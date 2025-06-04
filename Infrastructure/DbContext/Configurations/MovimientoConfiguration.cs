using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class MovimientoConfiguration : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> entity)
        {
            entity.HasKey(e => e.nIdMovimiento).HasName("PK_Movimiento");

            entity.Property(e => e.nIdMovimiento).UseIdentityColumn();

            entity.HasIndex(e => e.nIdTipoMovimiento, "fk_MovimientoEstadoCuenta_TipoMovimiento");

            entity.HasIndex(e => e.nIdTipoOperacion, "fk_MovimientoEstadoCuenta_TipoOperacion");

            entity.HasIndex(e => e.nIdParticipante, "fk_Movimiento_Participante");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nMonto).HasPrecision(18, 2);

            entity.Property(e => e.nSaldoFinal)
            .HasPrecision(18, 2)
            .HasComment("Esta columna corresponde al saldo que queda disponible tomando en cuenta el último saldo disponible menos la diferencia del monto (en este caso, ya sea, un cargo o un abono).");
            
            entity.Property(e => e.nSaldoInicial)
            .HasPrecision(18, 2)
            .HasComment("Esta columna corresponde al saldo antes de aplicar el movimiento");

            entity.Property(e => e.sConcepto)
            .IsRequired()
            .HasMaxLength(100);

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.Movimiento)
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Movimiento_Participante");

            entity.HasOne(d => d.nIdTipoMovimientoNavigation).WithMany(p => p.Movimiento)
            .HasForeignKey(d => d.nIdTipoMovimiento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_MovimientoEstadoCuenta_TipoMovimiento");

            entity.HasOne(d => d.nIdTipoOperacionNavigation).WithMany(p => p.Movimiento)
            .HasForeignKey(d => d.nIdTipoOperacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_MovimientoEstadoCuenta_TipoOperacion");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Movimiento> entity);
    }
}
