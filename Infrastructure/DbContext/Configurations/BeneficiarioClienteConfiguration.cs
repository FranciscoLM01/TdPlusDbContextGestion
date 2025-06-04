using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class BeneficiarioClienteConfiguration : IEntityTypeConfiguration<BeneficiarioCliente>
    {
        public void Configure(EntityTypeBuilder<BeneficiarioCliente> entity)
        {
            entity.HasKey(e => e.nIdBeneficiarioCliente).HasName("PK_BeneficiarioCliente");

            entity.Property(e => e.nIdBeneficiarioCliente).UseIdentityColumn();

            entity.HasIndex(e => e.nIdCliente, "fk_BeneficiarioClienteIndirecto_ClienteIndirecto");

            entity.HasIndex(e => e.nClaveInstitucion, "fk_BeneficiarioCliente_Institucion");

            entity.HasIndex(e => new { e.nTipoCuenta, e.sCuenta }, "unq_BeneficiarioClienteIndirecto").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sCuenta)
            .IsRequired()
            .HasMaxLength(20);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(40);

            entity.HasOne(d => d.nClaveInstitucionNavigation).WithMany(p => p.BeneficiarioCliente)
            .HasForeignKey(d => d.nClaveInstitucion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_BeneficiarioCliente_Institucion");

            entity.HasOne(d => d.nIdClienteNavigation).WithMany(p => p.BeneficiarioCliente)
            .HasForeignKey(d => d.nIdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_BeneficiarioClienteIndirecto_ClienteIndirecto");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BeneficiarioCliente> entity);
    }
}
