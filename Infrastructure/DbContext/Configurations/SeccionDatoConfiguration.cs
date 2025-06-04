using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class SeccionDatoConfiguration : IEntityTypeConfiguration<SeccionDato>
    {
        public void Configure(EntityTypeBuilder<SeccionDato> entity)
        {
            entity.HasKey(e => e.nIdSeccionDato).HasName("PK_SeccionDato");

            entity.Property(e => e.nIdSeccionDato).UseIdentityColumn();

            entity.HasIndex(e => e.nIdSeccion, "fk_SeccionDato_Seccion");

            entity.HasIndex(e => e.sIdentificador, "unq_SeccionDato_sIdentificador").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sIdentificador)
            .IsRequired()
            .HasMaxLength(10)
            .IsFixedLength()
            .HasComment("Esta columna corresponde al identificador del control, ya sea, un campo de texto, una lista desplegable. Con el proposito de identificar de que control viene la data o información.");

            entity.HasOne(d => d.nIdSeccionNavigation).WithMany(p => p.SeccionDato)
            .HasForeignKey(d => d.nIdSeccion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_SeccionDato_Seccion");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SeccionDato> entity);
    }
}
