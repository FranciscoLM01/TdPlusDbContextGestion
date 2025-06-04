using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class TipoCuentaEntidadConfiguration : IEntityTypeConfiguration<TipoCuentaEntidad>
    {
        public void Configure(EntityTypeBuilder<TipoCuentaEntidad> entity)
        {
            //Key
            entity.HasKey(r => r.nIdTipoCuentaEntidad).HasName("PK_TipoCuentaEntidad");
            entity.Property(e => e.nIdTipoCuentaEntidad).UseIdentityColumn();

            //Foreign keys

            //Unique Indexes
            entity.HasIndex(e => e.nIdTipoCuentaEntidad, "unq_TipoCuenta").IsUnique();

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
            entity.Property(e => e.sDescripcion)
           .IsRequired()
           .HasMaxLength(100)
           .HasComment("Esta columna corresponde al nombre del tipo de cuenta entidad.");

            //Navigations

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoCuentaEntidad> entity);
    }
}
