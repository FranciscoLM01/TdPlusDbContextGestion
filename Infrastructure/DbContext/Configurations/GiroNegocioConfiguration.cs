using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class GiroNegocioConfiguration : IEntityTypeConfiguration<GiroNegocio>
    {
        public void Configure(EntityTypeBuilder<GiroNegocio> entity)
        {
            entity.HasKey(e => e.nIdGiroNegocio).HasName("PK_GiroNegocio");

            entity.Property(e => e.nIdGiroNegocio).UseIdentityColumn();

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

        partial void OnConfigurePartial(EntityTypeBuilder<GiroNegocio> entity);
    }
}
