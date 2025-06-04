using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public class UsuarioPermisosConfiguration : IEntityTypeConfiguration<UsuarioPermisos>
    {
        public void Configure(EntityTypeBuilder<UsuarioPermisos> entity)
        {
            entity.ToTable("UsuarioPermisos");

            entity.HasKey(e => e.nIdUsuarioPermisos).HasName("PK_UsuarioPermisos");

            entity.Property(e => e.nIdUsuarioPermisos).UseIdentityColumn();

            entity.Property(e => e.nIdUsuarioPermisos)
                .IsRequired()
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.sNombre)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(false); 

            entity.Property(e => e.sDetalle)
                .HasColumnType("text")
                .IsUnicode(false);

            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
  
            entity.HasIndex(e => e.sNombre)
                .IsUnique()
                .HasDatabaseName("sNombre");
        }
    }
}
