using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SecuenciaConfiguration : IEntityTypeConfiguration<Secuencia>
    {
        public void Configure(EntityTypeBuilder<Secuencia> entity)
        {
            entity.HasKey(e => e.nIdSecuencia).HasName("PK_Secuencia");

            entity.Property(e => e.nIdSecuencia).UseIdentityColumn();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento)
                .HasColumnType("datetime")
                .HasDefaultValueSql("now()");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Secuencia> entity);
    }
}
