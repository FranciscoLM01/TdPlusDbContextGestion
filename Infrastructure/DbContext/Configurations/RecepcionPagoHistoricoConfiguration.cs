using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class RecepcionPagoHistoricoConfiguration
        : IEntityTypeConfiguration<RecepcionPagoHistorico>
    {
        public void Configure(EntityTypeBuilder<RecepcionPagoHistorico> entity)
        {
            //Key
            entity.HasKey(e => e.nIdRecepcionPagoHistorico).HasName("PK_RecepcionPagoHistorico");
            entity.Property(e => e.nIdRecepcionPagoHistorico).UseIdentityColumn();

            //Foreign keys
            entity.HasIndex(e => e.nIdRecepcionPago, "fk_RecepcionPagoHistorico_RecepcionPago");

            //Unique Indexes

            //Template
            entity.Property(e => e.bActivo).IsRequired().HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity
                .Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            //

            //Other columns
            entity.Property(e => e.nIdRecepcionPago).IsRequired(false);
            entity.Property(e => e.nIdParticipante).IsRequired();
            entity.Property(e => e.nIdCuentaClabe).IsRequired();
            entity.Property(e => e.sCuentaClabe).IsRequired(false).HasMaxLength(18);
            entity.Property(e => e.sProductoAsignado).IsRequired(false).HasMaxLength(100);
            entity.Property(e => e.sRfcCurp).IsRequired(false).HasMaxLength(20);
            entity.Property(e => e.sFechaOperacion).IsRequired();
            entity.Property(e => e.sClaveRastreo).IsRequired();
            entity.Property(e => e.nMonto).HasColumnType("decimal(18, 2)");

            //Navigations
            entity
                .HasOne(d => d.recepcionPagoNavigation)
                .WithMany(p => p.RecepcionPagoHistorico)
                .HasForeignKey(d => d.nIdRecepcionPago)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false)
                .HasConstraintName("fk_RecepcionHistorico_RecepcionPago");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RecepcionPagoHistorico> entity);
    }
}
