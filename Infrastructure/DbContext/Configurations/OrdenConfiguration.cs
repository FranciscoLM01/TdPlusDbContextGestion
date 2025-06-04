using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> entity)
        {
            entity.HasKey(e => e.nIdOrden).HasName("PK_Orden");

            entity.Property(e => e.nIdOrden).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla tiene el propósito de almacenar las órdenes que se enviarán a Banco de México"));

            entity.HasIndex(e => e.nIdBeneficiario, "fk_Orden_Beneficiario");

            entity.HasIndex(e => e.nIdOrdenTransferencia, "fk_orden_ordentransferencia");

            entity.Property(e => e.nIdOrden).HasComment("Esta columna corresponde a la llave primaria de la tabla. Esta columna es auto incrementable.");
            
            entity.Property(e => e.bCargaMasiva).HasComment("Esta columna identifica si la orden se creó a través de una carga masiva");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");
            
            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nIVA)
            .HasPrecision(18, 2)
            .HasComment("Esta columna corresponde al importe del IVA correspondientes al pago.");
            
            entity.Property(e => e.nMonto)
            .HasPrecision(18, 2)
            .HasComment("Esta columna corresponde al monto de la órden de transferencia.");
            
            entity.Property(e => e.nNumeroSecuencia).HasComment("Esta columna corresponde a un número de secuencia (1, 2, 3, 4, n) que se le asigna a una orden para que sea capaz de actualizarse el status de una orden. Es una columna que tiene el propósito de ser apoyo.");
            
            entity.Property(e => e.sClaveRastreo)
            .IsRequired()
            .HasMaxLength(30);
            
            entity.Property(e => e.sConceptoPago)
            .IsRequired()
            .HasMaxLength(40)
            .HasComment("Esta columna corresponde al motivo concepto de pago por el que se está haciendo la orden de transferencia, es decir, el motivo por el que el ordenante hace el pago al beneficiario");
            
            entity.Property(e => e.sReferenciaCobranza).HasMaxLength(40);
            
            entity.Property(e => e.sReferenciaNumerica)
            .HasMaxLength(7)
            .HasComment("Esta columna corresponse al dato numerico que sirve al ordenante para identificar el pago. Cabe mencionar, que si en caso el pago tenga como tipo de cuenta beneficiario un número de línea de telefonía móvil esta columna es opcional.");

            entity.HasOne(d => d.nIdBeneficiarioNavigation).WithMany(p => p.Orden)
            .HasForeignKey(d => d.nIdBeneficiario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Orden_Beneficiario");

            entity.HasOne(d => d.nIdOrdenTransferenciaNavigation).WithMany(p => p.Orden)
            .HasForeignKey(d => d.nIdOrdenTransferencia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_orden_ordentransferencia");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Orden> entity);
    }
}
