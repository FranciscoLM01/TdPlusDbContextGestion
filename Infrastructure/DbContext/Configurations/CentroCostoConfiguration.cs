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
    public partial class CentroCostoConfiguration : IEntityTypeConfiguration<CentroCosto>
    {
        public void Configure(EntityTypeBuilder<CentroCosto> entity)
        {
            //Key
            entity.HasKey(e => e.nIdCentroCosto).HasName("PK_CentroCosto");
            entity.Property(e => e.nIdCentroCosto).UseIdentityColumn();

            //Foreign keys
            entity.HasIndex(e => e.nIdEntidadProducto, "fk_CentroCosto_EntidadProducto");
            //entity.HasIndex(e => e.nIdCuentaConcentradora, "fk_CentroCosto_CuentaConcentradora");

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

            entity.Property(e => e.nIdTipoCentroCosto).IsRequired();
            entity.Property(e => e.Alias).IsRequired().HasMaxLength(100);
            entity.Property(e => e.nCentro).IsRequired();
            entity.Property(e => e.sCentro).IsRequired().HasMaxLength(100);
            entity.Property(e => e.nUltimoIdentificadorCta).IsRequired(false);
            entity.Property(e => e.nLimiteIdentificadorCta).IsRequired();
            entity.Property(e => e.sCadenaBaseCentro).IsRequired().HasMaxLength(100);
            entity.Property(e => e.bPrincipal).IsRequired().HasDefaultValue(false);
            entity.Property(e => e.nIdCuentaConcentradora).IsRequired(false);


            //Navigations

            entity.HasOne(d => d.nIdEntidadProductoNavigation).WithMany(p => p.CentroCosto)
            .HasForeignKey(d => d.nIdEntidadProducto)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_CentroCosto_EntidadProducto");


            entity.HasOne(d => d.CuentaConcentradora)
           .WithOne(p => p.CentroCosto)
           .HasForeignKey<CentroCosto>(p => p.nIdCuentaConcentradora)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("fk_CentroCosto_CuentaConcentradora");




            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CentroCosto> entity);
    }

}
