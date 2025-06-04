using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    public partial class TipoCentroCostoConfiguration : IEntityTypeConfiguration<TipoCentroCosto>
    {
        public void Configure(EntityTypeBuilder<TipoCentroCosto> entity)
        {
            entity.HasKey(tc => tc.nIdTipoCentroCosto);

            entity
                .HasMany(tc => tc.CentrosCosto)
                .WithOne(cc => cc.TipoCentroCosto)
                .HasForeignKey(cc => cc.nIdTipoCentroCosto)
                .OnDelete(DeleteBehavior.Restrict);

            entity.Property(tc => tc.sNombre)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(tc => tc.sDescripcion);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoCentroCosto> entity);
    }
}
