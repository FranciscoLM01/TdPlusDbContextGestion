using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class TipoOperacionConfiguration : IEntityTypeConfiguration<TipoOperacion>
    {
        public void Configure(EntityTypeBuilder<TipoOperacion> entity)
        {
            entity.HasKey(e => e.nIdTipoOperacion).HasName("PK_TipoOperacion");

            entity.Property(e => e.nIdTipoOperacion).UseIdentityColumn();

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
            .HasMaxLength(100)
            .HasComment("Esta columna corresponde al tipo de operación, por ejemplo, si el tipo de operación es de tipo C (Crédito) corresponde  a un cargo y si es D (Débito) corresponde a un abono.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoOperacion> entity);
    }
}
