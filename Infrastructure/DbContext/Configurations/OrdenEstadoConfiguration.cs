using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OrdenEstadoConfiguration : IEntityTypeConfiguration<OrdenEstado>
    {
        public void Configure(EntityTypeBuilder<OrdenEstado> entity)
        {
            entity.HasKey(e => e.nIdOrdenEstado).HasName("PK_OrdenEstado");

            entity.Property(e => e.nIdOrdenEstado).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla corresponde a los posibles estatus que puede tomar una orden, por ejemplo, la orden puede estar en Cola de envío, Liquidado, Abonado, etc."));

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(255);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrdenEstado> entity);
    }
}
