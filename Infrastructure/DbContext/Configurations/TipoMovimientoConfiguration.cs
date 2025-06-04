using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class TipoMovimientoConfiguration : IEntityTypeConfiguration<TipoMovimiento>
    {
        public void Configure(EntityTypeBuilder<TipoMovimiento> entity)
        {
            entity.HasKey(e => e.nIdTipoMovimiento).HasName("PK_TipoMovimiento");

            entity.Property(e => e.nIdTipoMovimiento).UseIdentityColumn();

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

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(1)
            .IsFixedLength()
            .HasComment("Este campo almacena el tipo de movimiento, por ejemplo, C corrresponde  a Crédito y D a Débito.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoMovimiento> entity);
    }
}
