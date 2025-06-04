using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class PlazaConfiguration : IEntityTypeConfiguration<Plaza>
    {
        public void Configure(EntityTypeBuilder<Plaza> entity)
        {
            entity.HasKey(e => e.nIdPlaza).HasName("PK_Plaza");

            entity.Property(e => e.nIdPlaza).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla corresponde a los números de plaza dónde se está aperturando una cuenta de un participante directo."));

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(10);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Plaza> entity);
    }
}
