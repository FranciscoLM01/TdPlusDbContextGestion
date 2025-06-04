using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ProspectoConfiguration : IEntityTypeConfiguration<Prospecto>
    {
        public void Configure(EntityTypeBuilder<Prospecto> entity)
        {
            entity.HasKey(e => e.nIdProspecto).HasName("PK_Prospecto");

            entity.Property(e => e.nIdProspecto).UseIdentityColumn();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sApellidoMaterno)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sApellidoPaterno)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sCorreoElectronico)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(30);

            entity.Property(e => e.sObservaciones).HasMaxLength(100);
            entity.Property(e => e.sTelefono)
            .IsRequired()
            .HasMaxLength(10);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Prospecto> entity);
    }
}
