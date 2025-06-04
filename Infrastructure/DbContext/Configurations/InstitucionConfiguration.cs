using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class InstitucionConfiguration : IEntityTypeConfiguration<Institucion>
    {
        public void Configure(EntityTypeBuilder<Institucion> entity)
        {
            entity.HasKey(e => e.nClaveInstitucion).HasName("PK_Institucion");

            entity.Property(e => e.nClaveInstitucion).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla almacenará el catalogos de los participantes o instituciones que están registrados en Banxico."));

            entity.HasIndex(e => e.nClaveInstitucion, "unq_Institucion").IsUnique();

            //entity.Property(e => e.nClaveInstitucion).ValueGeneratedNever();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Institucion> entity);
    }
}
