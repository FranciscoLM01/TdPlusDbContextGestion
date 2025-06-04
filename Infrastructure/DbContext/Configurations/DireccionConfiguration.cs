using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
    {
        public void Configure(EntityTypeBuilder<Direccion> entity)
        {
            entity.HasKey(e => e.nIdDireccion).HasName("PK_Direccion");

            entity.Property(e => e.nIdDireccion).UseIdentityColumn();

            entity.HasIndex(e => e.nIdColonia, "fk_direccion_colonia");

            entity.HasIndex(e => e.nIdEstado, "fk_direccion_estado");

            entity.HasIndex(e => e.nIdMunicipio, "fk_direccion_municipio");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sCalle)
            .IsRequired()
            .HasMaxLength(60);

            entity.Property(e => e.sNumeroExterior)
            .IsRequired()
            .HasMaxLength(10);

            entity.Property(e => e.sNumeroInterior).HasMaxLength(10);

            entity.HasOne(d => d.nIdColoniaNavigation).WithMany(p => p.Direccion)
            .HasForeignKey(d => d.nIdColonia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_direccion_colonia");

            entity.HasOne(d => d.nIdEstadoNavigation).WithMany(p => p.Direccion)
            .HasForeignKey(d => d.nIdEstado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_direccion_estado");

            entity.HasOne(d => d.nIdMunicipioNavigation).WithMany(p => p.Direccion)
            .HasForeignKey(d => d.nIdMunicipio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_direccion_municipio");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Direccion> entity);
    }
}
