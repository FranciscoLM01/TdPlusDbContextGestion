using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class BeneficiarioConfiguration : IEntityTypeConfiguration<Beneficiario>
    {
        public void Configure(EntityTypeBuilder<Beneficiario> entity)
        {
            entity.HasKey(e => e.nIdBeneficiario).HasName("PK_Beneficiario");

            entity.Property(e => e.nIdBeneficiario).UseIdentityColumn(); 

            entity.ToTable(tb => tb.HasComment("Esta tabla tiene el propósito de almacenar la información del beneficiario del otro participante directo al que se le enviará la órden de transferencia"));

            entity.HasIndex(e => e.nIdDireccion, "fk_Beneficiario_Direccion");

            entity.HasIndex(e => e.nIdParticipante, "fk_Beneficiario_Participante");

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            entity.Property(e => e.nTipoContribuyente).HasComment("Las personas físicas se representan con un 2 y las personas morales con un 1");

            entity.Property(e => e.sCorreo).HasMaxLength(100);

            entity.Property(e => e.sNombre)
            .IsRequired()
            .HasMaxLength(40);

            entity.Property(e => e.sRFCCURP)
            .IsRequired()
            .HasMaxLength(18)
            .HasComment("Según el manual de integración de Banxico, a partir del 10 de abril del 2024, el RFC o CURP será obligatorio.");
            
            entity.Property(e => e.sTelefono).HasMaxLength(10);

            entity.HasOne(d => d.nIdDireccionNavigation).WithMany(p => p.Beneficiario)
            .HasForeignKey(d => d.nIdDireccion)
            .HasConstraintName("fk_Beneficiario_Direccion");

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.Beneficiario)
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_Beneficiario_Participante");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Beneficiario> entity);
    }
}
