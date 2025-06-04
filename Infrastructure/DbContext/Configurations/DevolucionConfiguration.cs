using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations;

public class DevolucionConfiguration : IEntityTypeConfiguration<Devolucion>
{
    public void Configure(EntityTypeBuilder<Devolucion> entity)
    {
        // Configuración de la relación FK entre Devoluciones y CausasDevolucion
        //Key
        entity.HasKey(e => e.nIdDevolucion).HasName("PK_Devolucion");

        //Foreign keys
        entity.HasIndex(e => e.nIdCausaDevolucion, "fk_Devolucion_Causadevolucion");

        entity.Property(e => e.dFecRegistro)
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");

        entity
            .HasOne(d => d.CausaDevolucion)
            .WithMany() // Sin navegación inversa
            .HasForeignKey(d => d.nIdCausaDevolucion)
            .OnDelete(DeleteBehavior.Restrict); // Evita borrado en cascada
    }
}
