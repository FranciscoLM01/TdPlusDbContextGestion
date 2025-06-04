using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class TipoPagoConfiguration : IEntityTypeConfiguration<TipoPago>
    {
        public void Configure(EntityTypeBuilder<TipoPago> entity)
        {
            entity.HasKey(e => e.nClaveTipoPago).HasName("PK_TipoPago");

            entity.Property(e => e.nClaveTipoPago).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla almacenará los tipos de pago de Banxico, por ejemplo, Tercero a tercero, Devolución, Retorno, entre otros."));

            entity.HasIndex(e => e.nClaveTipoPago, "unq_TipoPago").IsUnique();

            //entity.Property(e => e.nClaveTipoPago)
            //.ValueGeneratedNever()
            //.HasComment("Esta columna corresponde al valor del campo clave del catalogo de Tipo de Pagos de Banxico. Por ejemplo: si la clave es 1, corresponde al pago Tercero a tercero.");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(100);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoPago> entity);
    }
}
