using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class NotificacionWebhookConfiguration : IEntityTypeConfiguration<NotificacionWebhook>
    {
        public void Configure(EntityTypeBuilder<NotificacionWebhook> entity)
        {
            entity.HasKey(e => e.nIdNotificacion).HasName("PK_NotificacionWebhook");

            entity.Property(e => e.nIdNotificacion).UseIdentityColumn();

            entity.HasIndex(e => e.nIdParticipante, "fk_NotificacionWebhook_Participante");

            entity.Property(e => e.nDescripcion)
            .IsRequired()
            .HasMaxLength(255);

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.NotificacionWebhook)
            .HasForeignKey(d => d.nIdParticipante)
            .HasConstraintName("fk_NotificacionWebhook_Participante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<NotificacionWebhook> entity);
    }
}
