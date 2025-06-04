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
    public partial class CuentaClabeEntidadConfiguration : IEntityTypeConfiguration<CuentaClabeEntidad>
    {
        public void Configure(EntityTypeBuilder<CuentaClabeEntidad> entity)
        {
            //Key
            entity.HasKey(r => new { r.nIdEntidad, r.nIdCuentaClabe, r.nIdCuentaConcentradora }).HasName("PK_CuentaClabeEntidad");


            //Foreign keys
            entity.HasIndex(e => e.nIdEntidad, "fk_CuentaClabeEntidad_Entidad");
            entity.HasIndex(e => e.nIdCuentaClabe, "fk_CuentaClabeEntidad_CuentaClabe");
            entity.HasIndex(e => e.nIdCuentaConcentradora, "fk_CuentaClabeEntidad_CuentaConcentradora");
            entity.HasIndex(e => e.nIdTipoCuentaEntidad, "fk_CuentaClabeEntidad_TipoCuentaEntidad");

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
            entity.Property(p => p.nIdTipoCuentaEntidad).IsRequired();


            //Navigations

            entity.HasOne(d => d.nIdEntidadNavigation).WithMany(p => p.CuentasClabeEntidad)
            .HasForeignKey(d => d.nIdEntidad)
            .HasConstraintName("fk_CuentaClabeEntidad_Entidad");

            entity.HasOne(d => d.nIdCuentaClabeNavigation).WithMany(p => p.CuentasClabeEntidad)
            .HasForeignKey(d => d.nIdCuentaClabe)
            .HasConstraintName("fk_CuentaClabeEntidad_CuentaClabe");

            entity.HasOne(d => d.nIdCuentaConcentradoraNavigation).WithMany(p => p.CuentasClabeEntidad)
            .HasForeignKey(d => d.nIdCuentaConcentradora)
            .HasConstraintName("fk_CuentaClabeEntidad_CuentaConcentradora");

            entity.HasOne(d => d.nIdTipoCuentaEntidadNavigation).WithMany(p => p.CuentasClabeEntidad)
            .HasForeignKey(d => d.nIdTipoCuentaEntidad)
            .HasConstraintName("fk_CuentaClabeEntidad_TipoCuentaEntidad");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CuentaClabeEntidad> entity);
    }
}
