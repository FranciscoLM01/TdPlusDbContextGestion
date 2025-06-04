using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdPlusDbContextGestion.Domain.Entities;

namespace TdPlusDbContextGestion.Infrastructure.DbContext.Configurations
{
    internal class OperacionCompensacionConfiguration : IEntityTypeConfiguration<OperacionCompensacion>
    {
        public void Configure(EntityTypeBuilder<OperacionCompensacion> builder)
        {

            builder.ToTable("Operaciones_Compensacion");

            builder.Property(e => e.Categoria)
                  .IsRequired()
                  .HasMaxLength(50);

            builder.Property(e => e.Operacion)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(e => e.PlazoMaximoSegundos).HasColumnName("Plazo_Maximo_Segundos");

            builder.Property(e => e.PlazoLimiteHorario).HasColumnName("Plazo_Limite_Horario")
                  .HasMaxLength(20);

            builder.Property(e => e.MontoReferencia)
                    .HasColumnName("Monto_Referencia")
                  .HasColumnType("decimal(15,2)")
                  .HasDefaultValue(0.00m);

            builder.Property(e => e.TasaCompensacion).HasColumnName("Tasa_Compensacion")
                  .HasColumnType("decimal(5,2)")
                  .HasDefaultValue(0.00m);

            builder.Property(e => e.Nota);

            builder.Property(e => e.ReferenciaRegla).HasColumnName("Referencia_Regla")
                  .HasMaxLength(100);
        }
    }
}

