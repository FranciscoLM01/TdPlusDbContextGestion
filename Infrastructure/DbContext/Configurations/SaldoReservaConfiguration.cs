using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SaldoReservaConfiguration : IEntityTypeConfiguration<SaldoReserva>
    {
        public void Configure(EntityTypeBuilder<SaldoReserva> entity)
        {
            entity.HasKey(e => e.nIdSaldoReserva).HasName("PK_SaldoReserva");

            entity.Property(e => e.nIdSaldoReserva).UseIdentityColumn();

            entity.HasIndex(e => e.nIdParticipante, "fk_SaldoReserva_Participante");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nSaldoActual).HasPrecision(18, 2);

            entity.Property(e => e.nSaldoReservado)
            .HasPrecision(18, 2)
            .HasComment("Esta columna corresponde a la suma de los montos de las ordenes");

            entity.Property(e => e.nSaldoReservadoDevolver)
            .HasPrecision(18, 2)
            .HasComment("Esta columna es calculada haciendo una resta o diferencia con la colummna nSaldoReservado y nTotalTransferido (nSaldoReservado - nTotalTransferido)");

            entity.Property(e => e.nTotalTransferido)
            .HasPrecision(18, 2)
            .HasComment("Esta columna corresponde al monto total de las ordenes que ya se han liquidado");

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.SaldoReserva)
            .HasForeignKey(d => d.nIdParticipante)
            .HasConstraintName("fk_SaldoReserva_Participante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SaldoReserva> entity);
    }
}
