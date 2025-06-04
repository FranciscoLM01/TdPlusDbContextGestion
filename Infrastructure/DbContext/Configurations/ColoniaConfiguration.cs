using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ColoniaConfiguration : IEntityTypeConfiguration<Colonia>
    {
        public void Configure(EntityTypeBuilder<Colonia> entity)
        {
            entity.HasKey(e => e.nIdColonia).HasName("PK_Colonia");

            entity.Property(e => e.nIdColonia).UseIdentityColumn();

            entity.HasIndex(e => e.nIdMunicipio, "fk_colonia_municipio");

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

            entity.Property(e => e.sNombreEstado)
            .IsRequired()
            .HasMaxLength(60);

            entity.Property(e => e.sNombreMunicipio)
            .IsRequired()
            .HasMaxLength(60);

            entity.Property(e => e.sTipoAsentamiento)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.sTipoZona).HasMaxLength(50);

            entity.HasOne(d => d.nIdMunicipioNavigation).WithMany(p => p.Colonia)
            .HasForeignKey(d => d.nIdMunicipio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_colonia_municipio");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Colonia> entity);
    }
}
