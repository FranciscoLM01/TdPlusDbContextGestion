using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class CausaDevolucionConfiguration : IEntityTypeConfiguration<CausaDevolucion>
    {
        public void Configure(EntityTypeBuilder<CausaDevolucion> entity)
        {
            entity.HasKey(e => e.nClaveCausaDevolucion).HasName("PK_CausaDevolucion");

            entity.Property(e => e.nClaveCausaDevolucion).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla corresponde a las posibles causas de devolución cuando se hace un proceso de devolución de una orden"));

            entity.HasIndex(e => e.nClaveCausaDevolucion, "unq_CausaDevolucion").IsUnique();

            //entity.Property(e => e.nClaveCausaDevolucion)
            //.ValueGeneratedNever()
            //.HasComment("Esta columna corresponde al valor del campo clave del catalogo de Causa devolución de Banxico. Por ejemplo: si la clave es 1, corresponde a Cuenta inexistente.");

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

        partial void OnConfigurePartial(EntityTypeBuilder<CausaDevolucion> entity);
    }
}
