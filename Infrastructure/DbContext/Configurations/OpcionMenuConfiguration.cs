using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OpcionMenuConfiguration : IEntityTypeConfiguration<OpcionMenu>
    {
        public void Configure(EntityTypeBuilder<OpcionMenu> entity)
        {
            entity.HasKey(e => e.nIdMenuOpcion).HasName("PK_OpcionMenu");

            entity.Property(e => e.nIdMenuOpcion).UseIdentityColumn();

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

            entity.Property(e => e.sRuta)
            .IsRequired()
            .HasMaxLength(50)
            .HasComment("Esta columna corresponde a la URL o ruta relativa de la opción. Está precedida por una barra diagonal y, por convención, debe se escribirse en minusculas sin caracteres especiales ni espacios.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OpcionMenu> entity);
    }
}
