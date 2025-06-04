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
    public partial class CuentaClabeConfiguration : IEntityTypeConfiguration<CuentaClabe>
    {
        public void Configure(EntityTypeBuilder<CuentaClabe> entity)
        {
            //Key
            entity.HasKey(e => e.nIdCuentaClabe).HasName("PK_CuentaClabe");
            entity.Property(e => e.nIdCuentaClabe).UseIdentityColumn();

            //Foreign keys
            entity.HasIndex(e => e.nIdCentroCosto, "fk_CuentaClabe_CentroCosto");

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

            entity.Property(e => e.nIdentificadorCta).IsRequired();
            entity.Property(e => e.sIdentificadorCta).IsRequired();
            entity.Property(e => e.sCadenaBaseCta).IsRequired().HasMaxLength(100);
            entity.Property(e => e.nDigitoVerificador).IsRequired();
            entity.Property(e => e.sCuentaClabe).IsRequired();
            entity.Property(e => e.bReutilizar).IsRequired().HasDefaultValue(false);
            entity.Property(e => e.nIdStatus).IsRequired();

            //Navigations

            entity.HasOne(d => d.nIdCentroCostoNavigation).WithMany(p => p.CuentaClabe)
            .HasForeignKey(d => d.nIdCentroCosto)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_CuentaClabe_CentroCosto");





            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CuentaClabe> entity);
    }

}
