using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public class OpcionMenuUsuarioPermisosConfiguration : IEntityTypeConfiguration<OpcionMenuUsuarioPermisos>
    {
        public void Configure(EntityTypeBuilder<OpcionMenuUsuarioPermisos> builder)
        {
            builder.ToTable("OpcionMenuUsuarioPermisos");

            // PK compuesta
            builder.HasKey(e => new { e.nIdMenuOpcion, e.nIdUsuarioPermisos });

            // Relación con OpcionMenu
            builder.HasOne(e => e.OpcionMenu)
                .WithMany()
                .HasForeignKey(e => e.nIdMenuOpcion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_6ADY");

            // Relación con UsuarioPermisos
            builder.HasOne(e => e.UsuarioPermisos)
                .WithMany()
                .HasForeignKey(e => e.nIdUsuarioPermisos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_6V5L");
        }
    }
}
