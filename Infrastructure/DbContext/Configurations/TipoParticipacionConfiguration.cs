using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class TipoParticipacionConfiguration : IEntityTypeConfiguration<TipoParticipacion>
    {
        public void Configure(EntityTypeBuilder<TipoParticipacion> entity)
        {
            entity.HasKey(e => e.nIdTipoParticipante).HasName("PK_TipoParticipante");

            entity.Property(e => e.nIdTipoParticipante).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta corresponde al tipo de participante, por ejemplo, directo o indirecto"));

            //entity.Property(e => e.nIdTipoParticipante).ValueGeneratedNever();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(50)
            .HasComment("Esta columna se refiere al nombre del tipo de participante: directo o indirecto");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoParticipacion> entity);
    }
}
