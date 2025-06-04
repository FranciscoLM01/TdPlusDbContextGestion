using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OrdenTransferenciaConfiguration : IEntityTypeConfiguration<OrdenTransferencia>
    {
        public void Configure(EntityTypeBuilder<OrdenTransferencia> entity)
        {
            entity.HasKey(e => e.nIdOrdenTransferencia).HasName("PK_OrdenTransferencia");

            entity.Property(e => e.nIdOrdenTransferencia).UseIdentityColumn();

            entity.HasIndex(e => e.nIdOrdenante, "fk_OrdenTransferencia_Ordenante");

            entity.HasIndex(e => e.nClaveTipoPago, "unq_OrdenTransferencia_nClaveTipoPago");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nClavePeticion).HasComment("Corresponde a la clave de petición del request a MEAPI. Por ejemplo, si el objetivo es registrar un pago se hace una petición con número 19.");
            
            entity.Property(e => e.nIdOrdenante).HasComment("Esta columna se refiere al ordenante de la orden de transferencia, es importante señalar que un ordenante puede ser un participante directo o un participante indirecto");
            
            entity.Property(e => e.nNumeroEntidad).HasComment("Esta columna corrresponde al identificador único que se le asigna a un participante indirecto");
            
            entity.Property(e => e.sClaveCifrado)
            .HasMaxLength(15)
            .HasComment("Esta columna corresponde al ID de clave de cifrado, es decir, es una concatenación del año, mes. día, hora, minutos, segundos y milisegundos.");

            entity.HasOne(d => d.nClaveTipoPagoNavigation).WithMany(p => p.OrdenTransferencia)
            .HasForeignKey(d => d.nClaveTipoPago)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_OrdenTransferencia_TipoPago");

            entity.HasOne(d => d.nIdOrdenanteNavigation).WithMany(p => p.OrdenTransferencia)
            .HasForeignKey(d => d.nIdOrdenante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_OrdenTransferencia_Ordenante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrdenTransferencia> entity);
    }
}
