using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class RecepcionPagoConfiguration: IEntityTypeConfiguration<RecepcionPago>
    {

        public void Configure(EntityTypeBuilder<RecepcionPago> entity)
        {
            //Key
            entity.HasKey(e => e.nIdRecepcion).HasName("PK_RecepcionPago");
            entity.Property(e => e.nIdRecepcion).UseIdentityColumn();

            //Foreign keys
            entity.HasIndex(e => e.nIdParticipante, "fk_RecepcionPago_Participante");
            entity.HasIndex(e => e.nIdCuentaClabe, "fk_RecepcionPago_CuentaClabe");

            //Unique Indexes

            //Template
            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            //

            //Other columns
            entity.Property(e => e.nIdParticipante).IsRequired();
            entity.Property(e => e.nIdCuentaClabe).IsRequired();
            entity.Property(e => e.sProductoAsignado).IsRequired(false).HasMaxLength(100);
            entity.Property(e => e.bRecurrente).IsRequired(false).HasDefaultValue(false);
            entity.Property(e => e.sRfcCurp).IsRequired(false).HasMaxLength(20);
            entity.Property(e => e.bRecepcionActiva).IsRequired().HasDefaultValue(1);
            entity.Property(e => e.dVigencia).IsRequired(false);
            entity.Property(e => e.dFechaAsignacion).IsRequired(false);
            entity.Property(e => e.dFechaLiberacion).IsRequired(false);
            entity.Property(e => e.dFechaPago).IsRequired(false);
            entity.Property(e => e.nIdEstatus).IsRequired();
            entity.Property(e => e.nMonto).IsRequired(false);
                        
            //Navigations
            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.RecepcionPago)
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_Recepcion_Participante");

            entity.HasOne(d => d.nIdCuentaClabeNavigation).WithMany(p => p.RecepcionPago)
           .HasForeignKey(d => d.nIdCuentaClabe)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("fk_Recepcion_CuentaClabe");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RecepcionPago> entity);
    }
}
