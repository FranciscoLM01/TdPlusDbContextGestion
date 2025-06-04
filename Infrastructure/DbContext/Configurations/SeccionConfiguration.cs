using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SeccionConfiguration : IEntityTypeConfiguration<Seccion>
    {
        public void Configure(EntityTypeBuilder<Seccion> entity)
        {
            entity.HasKey(e => e.nIdSeccion).HasName("PK_Seccion");

            entity.Property(e => e.nIdSeccion).UseIdentityColumn();

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
            .HasMaxLength(100);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Seccion> entity);
    }
}
