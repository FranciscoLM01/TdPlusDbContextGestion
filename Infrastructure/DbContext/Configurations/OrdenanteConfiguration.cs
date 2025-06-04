using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class OrdenanteConfiguration : IEntityTypeConfiguration<Ordenante>
    {
        public void Configure(EntityTypeBuilder<Ordenante> entity)
        {
            entity.HasKey(e => e.nIdOrdenante).HasName("PK_Ordenante");

            entity.Property(e => e.nIdOrdenante).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla almacena los ordenantes para las ordenes."));

            entity.HasIndex(e => e.nIdParticipante, "fk_Ordenante_Participante");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nIdParticipante).HasComment("Esta columna corresponde al ID único cuando se agregue un participante directo y un participante indirecto");

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.Ordenante)
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Ordenante_Participante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Ordenante> entity);
    }
}
