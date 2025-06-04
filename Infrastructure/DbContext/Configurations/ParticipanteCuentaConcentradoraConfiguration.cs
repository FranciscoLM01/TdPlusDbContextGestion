using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ParticipanteCuentaConcentradoraConfiguration : IEntityTypeConfiguration<ParticipanteCuentaConcentradora>
    {
        public void Configure(EntityTypeBuilder<ParticipanteCuentaConcentradora> entity)
        {
            entity.HasKey(e => new { e.nIdParticipante, e.nIdCuentaConcentradora, e.bActivo });

            entity.HasIndex(e => e.nIdCuentaConcentradora, "fk_PaInCuentaConcentradora_CuentaConcentradora");

            entity.HasIndex(e => new { e.nIdParticipante, e.nIdCuentaConcentradora, e.bActivo }, "unq_PaInCuentaConcentradora").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.nIdCuentaConcentradoraNavigation).WithMany()
            .HasForeignKey(d => d.nIdCuentaConcentradora)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_PaInCuentaConcentradora_CuentaConcentradora");

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany()
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_ParticipanteCuentaConcentradora_Participante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ParticipanteCuentaConcentradora> entity);
    }
}
