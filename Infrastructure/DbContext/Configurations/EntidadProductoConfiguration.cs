using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{

    public partial class EntidadProductoConfiguration : IEntityTypeConfiguration<EntidadProducto>
    {
        public void Configure(EntityTypeBuilder<EntidadProducto> entity)
        {
            //Key
            entity.HasKey(e => e.nIdEntidadProducto).HasName("PK_EntidadProducto");
            entity.Property(e => e.nIdEntidadProducto).UseIdentityColumn();

            //Foreign keys
            entity.HasIndex(e => e.nIdEntidad, "fk_EntidadProducto_Entidad");

            //Unique Indexes

            //Template
            entity.Property(e => e.bActivo)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(e => e.dFecMovimiento).HasColumnType("datetime");

            entity.Property(e => e.dFecRegistro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            //

            //Other columns
            entity.Property(e => e.nIdProductoFinanciero).IsRequired();
            entity.Property(e => e.nUltimoCentro).IsRequired();
            entity.Property(e => e.nLimiteCentroCosto).IsRequired();
            entity.Property(e => e.nUltimoCentro).IsRequired(false);
            entity.Property(e => e.sCadenaBaseEntidad).IsRequired().HasMaxLength(100);


            //Navigations

            entity.HasOne(d => d.nIdEntidadNavigation).WithMany(p => p.EntidadProducto)
            .HasForeignKey(d => d.nIdEntidad)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_EntidadProducto_Entidad");





            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EntidadProducto> entity);
    }
}
