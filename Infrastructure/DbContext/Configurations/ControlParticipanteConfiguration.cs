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
    public partial class ControlParticipanteConfiguration : IEntityTypeConfiguration<ControlParticipante>
    {
        public void Configure(EntityTypeBuilder<ControlParticipante> entity)
        {
            //Key
            entity.HasKey(e => e.nIdControlParticipante).HasName("PK_ControlParticipante");
            entity.Property(e => e.nIdControlParticipante).UseIdentityColumn();

            //Foreign keys
            entity.HasIndex(e => e.nIdTipoParticipante, "fk_ControlParticipante_TipoParticipante");

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
            entity.Property(e => e.nClaveSpei).IsRequired();
            entity.Property(e => e.nConstante).IsRequired(false);
            entity.Property(e => e.nLimiteConstante).IsRequired(false);
            entity.Property(e => e.sUltimaEntidad).IsRequired(false).HasMaxLength(10);
            entity.Property(e => e.nUltimaEntidad).IsRequired(false);
            entity.Property(e => e.nLongitudEntidad).IsRequired();
            entity.Property(e => e.nLimiteEntidad).IsRequired();
            entity.Property(e => e.nLongitudCentro).IsRequired();
            entity.Property(e => e.nLongitudIdentificadorCuenta).IsRequired();
            entity.Property(e => e.nLongitudVerificador).IsRequired();
            entity.Property(e => e.bAgotado).IsRequired().HasDefaultValue(0);

            //Navigations

            entity.HasOne(d => d.nIdTipoParticipanteNavigation).WithMany(p => p.ControlParticipante)
            .HasForeignKey(d => d.nIdTipoParticipante)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_ControlParticipante_TipoParticipante");




            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ControlParticipante> entity);
    }
}
