using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ParticipanteConfiguration : IEntityTypeConfiguration<Participante>
    {
        public void Configure(EntityTypeBuilder<Participante> entity)
        {
            entity.HasKey(e => e.nIdParticipante).HasName("PK_Participante");

            entity.Property(e => e.nIdParticipante).UseIdentityColumn();

            entity.HasIndex(e => e.nIdTipoParticipante, "fk_Participante_TipoParticipante");

            entity.HasIndex(e => e.nIdCuentaConcentradora, "unq_ParticipanteDirecto_nIdCuenta_0").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nIdTipoParticipante).HasComment("Esta columna corresponde al tipo de participante, ya sea directo o indirecto");

            entity.Property(e => e.sRFC)
            .IsRequired()
            .HasMaxLength(13);

            entity.Property(e => e.sRazonSocial)
            .IsRequired()
            .HasMaxLength(100);

            entity.Property(e => e.sNombre)
            .HasComment("Número generañ de la entidad")
            .IsRequired()
           .HasMaxLength(100);

            entity.Property(e => e.sTelefono)
            .HasComment("Teléfono asociado a la entidad")
            .IsRequired()
           .HasMaxLength(10);

            entity.Property(e => e.sContacto)
            .HasComment("Contacto asociado a la entidad")
            .IsRequired()
           .HasMaxLength(100);

            entity.Property(e => e.sCorreo)
            .HasComment("Correo de contacto de la entidad")
            .IsRequired()
           .HasMaxLength(100);

            entity.Property(e => e.dFechaIngreso)
            .HasComment("Fecha en la cual se registró la entidad.")
            .IsRequired();

            entity.Property(e => e.nNumeroEntidad)
            .HasComment("Número identificador de la entidad")
            .IsRequired();

            entity.HasOne(d => d.nIdTipoParticipanteNavigation).WithMany(p => p.Participante)
            .HasForeignKey(d => d.nIdTipoParticipante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Participante_TipoParticipante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Participante> entity);
    }
}
