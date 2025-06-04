using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.HasKey(e => e.nIdCliente).HasName("PK_Cliente");

            entity.Property(e => e.nIdCliente).UseIdentityColumn();

            entity.HasIndex(e => e.nIdParticipante, "fk_Cliente_Participante");

            entity.HasIndex(e => e.nIdCuentaConcentradora, "unq_ClienteParticipanteIndirecto_nIdCuenta").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nClaveCuenta).HasComment("Esta columna corresponde al identificador único del centro de costos o cliente indirecto");
           
            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(100);

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.Cliente)
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Cliente_Participante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Cliente> entity);
    }
}
