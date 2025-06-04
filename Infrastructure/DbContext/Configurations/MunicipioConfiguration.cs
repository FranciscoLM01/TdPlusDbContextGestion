using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> entity)
        {
            entity.HasKey(e => e.nIdMunicipio).HasName("PK_Municipio");

            entity.Property(e => e.nIdMunicipio).UseIdentityColumn();

            entity.HasIndex(e => e.nIdEstado, "fk_municipio_estado");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(100);

            entity.HasOne(d => d.nIdEstadoNavigation).WithMany(p => p.Municipio)
            .HasForeignKey(d => d.nIdEstado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_municipio_estado");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Municipio> entity);
    }
}
