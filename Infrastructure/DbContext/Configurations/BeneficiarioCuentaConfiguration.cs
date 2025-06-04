using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class BeneficiarioCuentaConfiguration : IEntityTypeConfiguration<BeneficiarioCuenta>
    {
        public void Configure(EntityTypeBuilder<BeneficiarioCuenta> entity)
        {
            entity.HasKey(e => new { e.nIdBeneficiario, e.nClaveTipoCuenta, e.sCuenta });

            entity.HasIndex(e => e.nClaveInstitucion, "fk_BeneficiarioCuenta_Institucion");

            entity.HasIndex(e => e.nClaveTipoCuenta, "fk_BeneficiarioCuenta_TipoCuenta");

            entity.HasIndex(e => new { e.nIdBeneficiario, e.nClaveTipoCuenta, e.sCuenta }, "unq_BeneficiarioCuenta").IsUnique();

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.sBanco)
            .IsRequired()
            .HasMaxLength(20)
            .HasComment("Nombre del banco");

            entity.Property(e => e.sCuenta)
            .IsRequired()
            .HasMaxLength(20)
            .HasComment("Corresponde al número de cuenta (CLABE)");

            entity.HasOne(d => d.nClaveInstitucionNavigation).WithMany()
            .HasForeignKey(d => d.nClaveInstitucion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_BeneficiarioCuenta_Institucion");

            entity.HasOne(d => d.nClaveTipoCuentaNavigation).WithMany()
            .HasForeignKey(d => d.nClaveTipoCuenta)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_BeneficiarioCuenta_TipoCuenta");

            entity.HasOne(d => d.nIdBeneficiarioNavigation).WithMany()
            .HasForeignKey(d => d.nIdBeneficiario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_beneficiariocuenta_beneficiario");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BeneficiarioCuenta> entity);
    }
}
