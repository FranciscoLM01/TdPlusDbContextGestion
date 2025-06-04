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

    public partial class EntidadConfiguration : IEntityTypeConfiguration<Entidad>
    {
        public void Configure(EntityTypeBuilder<Entidad> entity)
        {
            //Key
            entity.HasKey(e => e.nIdEntidad).HasName("PK_Entidad");
            entity.Property(e => e.nIdEntidad).UseIdentityColumn();

            //Foreign keys
            entity.HasIndex(e => e.nIdControlParticipante, "fk_Entidad_ControlParticipante");
            entity.HasIndex(e => e.nIdParticipante, "fk_Entidad_Participante");

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
            entity.Property(e => e.Alias).HasComment("Esta columna corresponde al Alias de la entidad")
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.nConstante).IsRequired();
            entity.Property(e => e.nEntidad).IsRequired();
            entity.Property(e => e.sEntidad).IsRequired().HasMaxLength(100);
            entity.Property(e => e.bPrincipal).IsRequired().HasDefaultValue(0);


            //Navigations

            entity.HasOne(d => d.nIdControlParticipanteNavigation).WithMany(p => p.Entidad)
            .HasForeignKey(d => d.nIdControlParticipante)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_Entidad_ControlParticipante");

            entity.HasOne(d => d.nIdParticipanteNavigation).WithMany(p => p.Entidad)
            .HasForeignKey(d => d.nIdParticipante)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_Entidad_Participante");



            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Entidad> entity);
    }
}
