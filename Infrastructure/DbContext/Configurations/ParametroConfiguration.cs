using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ParametroConfiguration : IEntityTypeConfiguration<Parametro>
    {
        public void Configure(EntityTypeBuilder<Parametro> entity)
        {
            entity.HasKey(e => e.nIdParametro).HasName("PK_Parametro");

            entity.Property(e => e.nIdParametro).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla se refiere a la parametrización de valores y funciones que requieran los aplicativos."));

            entity.HasIndex(e => e.sClave, "unq_Parametro").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sClave)
            .IsRequired()
            .HasMaxLength(100)
            .HasComment("Esta columna se refiere al nombre del parámetro, tiene que ser único y no debe de tener espacios ni caracteres especiales");

            entity.Property(e => e.sDescripcion)
            .IsRequired()
            .HasMaxLength(255)
            .HasComment("Esta columna se refiere a  la descripción dónde se explique el uso del parámetro");

            entity.Property(e => e.sModulo)
            .IsRequired()
            .HasMaxLength(100)
            .HasComment("Esta columna se refiere a la aplicación o módulo que hace uso del parámetro o en qué aplicaciones o modulos se aplicará el parámetro");

            entity.Property(e => e.sValor)
            .IsRequired()
            .HasMaxLength(255)
            .HasComment("Esta columna se refiere al valor del parámetro");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Parametro> entity);
    }
}
