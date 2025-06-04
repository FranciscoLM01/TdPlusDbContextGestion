namespace TdPlusDbContextGestion.Domain.Entities
{
    public class OperacionCompensacion
    {
        public int Id { get; set; }

        public string Categoria { get; set; } = string.Empty;

        public string Operacion { get; set; } = string.Empty;

        public int? PlazoMaximoSegundos { get; set; }

        public string? PlazoLimiteHorario { get; set; } = string.Empty;

        public decimal? MontoReferencia { get; set; } = 0.00m;

        public decimal? TasaCompensacion { get; set; } = 0.00m;

        public string? Nota { get; set; } = string.Empty;

        public string ReferenciaRegla { get; set; } = string.Empty;
    }
}
