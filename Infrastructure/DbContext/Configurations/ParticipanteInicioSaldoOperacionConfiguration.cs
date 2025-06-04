using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ParticipanteInicioSaldoOperacionConfiguration : IEntityTypeConfiguration<ParticipanteInicioSaldoOperacion>
    {
        public void Configure(EntityTypeBuilder<ParticipanteInicioSaldoOperacion> entity)
        {
            entity.HasKey(e => new { e.nIdParticipante, e.dFechaOperacion });

            entity
            .ToTable(tb => tb.HasComment("Esta es la tabla que almacena el saldo del participante en función del cambio de la fecha de operación del SPEI"));

            entity.HasIndex(e => e.nIdParticipante, "fk_ParticipanteInicioSaldoOperacion_Participante");

            entity.Property(e => e.nSaldoInicio)
            .HasPrecision(18, 2)
            .HasComment("Esta columna hace referencia al saldo inicial del participante conforme cambia la fecha de operación");

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany()
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ParticipanteInicioSaldoOperacion_Participante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ParticipanteInicioSaldoOperacion> entity);
    }
}
