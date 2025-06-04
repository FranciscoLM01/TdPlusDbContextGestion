using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.Persistence.Configurations
{
    public class OpcionMenuAccionUsuarioPermisosConfiguration : IEntityTypeConfiguration<OpcionMenuAccionUsuarioPermisos>
    {
        public void Configure(EntityTypeBuilder<OpcionMenuAccionUsuarioPermisos> builder)
        {
            builder.ToTable("OpcionMenuAccionUsuarioPermisos");

            // Llave primaria compuesta
            builder.HasKey(e => new { e.nIdOpcionMenuAccion, e.nIdUsuarioPermisos });

            // Foreign key relationship for nIdOpcionMenuAccion
            builder.HasOne(e => e.OpcionMenuAccion)
                .WithMany()
                .HasForeignKey(e => e.nIdOpcionMenuAccion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_2C16");

            // Foreign key relationship for nIdUsuarioPermisos
            builder.HasOne(e => e.UsuarioPermisos)
                .WithMany()
                .HasForeignKey(e => e.nIdUsuarioPermisos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_QB4N");

            // Indexes
            builder.HasIndex(e => e.nIdOpcionMenuAccion)
                .HasDatabaseName("FK_6ADY");
        }
    }
}
