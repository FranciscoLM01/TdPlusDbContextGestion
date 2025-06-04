using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class ProductoFinancieroConfiguration : IEntityTypeConfiguration<ProductoFinanciero>
    {
        public void Configure(EntityTypeBuilder<ProductoFinanciero> entity)
        {
            entity.HasKey(e => e.nIdProductoFinanciero).HasName("PK_ProductoFinanciero");

            entity.Property(e => e.nIdProductoFinanciero).UseIdentityColumn();

            entity.ToTable(tb => tb.HasComment("Esta tabla corresponde al catalogo de productos financieros aplicables a los servicios de participación indirecta"));

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento)
            .HasComment("Esta columna corresponde a la fecha y hora de actualización del registro.")
            .HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.Property(e => e.nClave)
            .IsRequired()
            .HasComment("Esta columna corresponde al identificador único del producto financiero");

            entity.Property(e => e.sDescripción)
            .IsRequired()
            .HasComment("Esta columna corresponde a la descripción del producto financiero");

            entity.HasOne(p => p.TipoParticipante)
               .WithMany(t => t.ProductosFinancieros)
               .HasForeignKey(p => p.nIdTipoParticipante)
               .OnDelete(DeleteBehavior.Restrict); 

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductoFinanciero> entity);
    }
}
