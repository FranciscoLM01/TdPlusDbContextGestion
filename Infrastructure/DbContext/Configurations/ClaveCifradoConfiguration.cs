using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ClaveCifradoConfiguration : IEntityTypeConfiguration<ClaveCifrado>
    {
        public void Configure(EntityTypeBuilder<ClaveCifrado> entity)
        {
            entity.HasKey(e => e.nIdClaveCifrado).HasName("PK_ClaveCifrado");

            entity.Property(e => e.nIdClaveCifrado).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla almacenará las claves de cfrado (clave simétrica y vector de inicialización) para el algoritmo AES 128 en modo CBC y llevar a cabo el cifrado y descifrado de los datos."));

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sClaveSimetrica)
            .IsRequired()
            .HasMaxLength(100);

            entity.Property(e => e.sIdentificador)
            .IsRequired()
            .HasMaxLength(20);

            entity.Property(e => e.sVectorInicializacion)
            .IsRequired()
            .HasMaxLength(100);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ClaveCifrado> entity);
    }
}
